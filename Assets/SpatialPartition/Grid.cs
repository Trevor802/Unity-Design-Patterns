using UnityEngine;
using Unity.Collections;

namespace SpatialPartition
{
    public class Grid : MonoBehaviour
    {
        public Unit UnitPrefab;

        [ReadOnly]
        public int UnitAmount = 10;
        private Unit[,] units = new Unit[NUM_CELLS, NUM_CELLS];
        private const int NUM_CELLS = 10;

        private void Awake()
        {
            for (int i = 0; i < UnitAmount; i++)
            {
                var unit = Instantiate(UnitPrefab,
                    UnitPrefab.GetRandomPosition(), Quaternion.identity);
                unit.transform.parent = transform;
                unit.Injection(this);
                AddUnit(unit);
            }
        }

        private void Update()
        {
            HandleInfect();
        }

        private void AddUnit(Unit unit)
        {
            int cellX = (int)unit.transform.position.x;
            int cellZ = (int)unit.transform.position.z;
            unit.Prev = null;
            unit.Next = units[cellX, cellZ];
            units[cellX, cellZ] = unit;
            if (unit.Next != null)
                unit.Next.Prev = unit;
        }

        public void UpdateUnits(Unit unit)
        {
            int oldCellX = (int)unit.transform.position.x;
            int oldCellZ = (int)unit.transform.position.z;
            unit.Move();
            int cellX = (int)unit.transform.position.x;
            int cellZ = (int)unit.transform.position.z;

            if (oldCellX == cellX && oldCellZ == cellZ) return;

            if (unit.Prev != null)
                unit.Prev.Next = unit.Next;
            if (unit.Next != null)
                unit.Next.Prev = unit.Prev;
            if (units[oldCellX, oldCellZ] == unit)
                units[oldCellX, oldCellZ] = unit.Next;
            AddUnit(unit);
        }

        private void HandleInfect()
        {
            for (int i = 0; i < NUM_CELLS; i++)
            {
                for (int j = 0; j < NUM_CELLS; j++)
                {
                    HandleCell(i, j);
                }
            }
        }

        private void HandleCell(int x, int z)
        {
            var unit = units[x, z];
            while (unit != null)
            {
                InfectUnit(unit, unit.Next);
                if (x > 0) InfectUnit(unit, units[x - 1, z]);
                if (z > 0) InfectUnit(unit, units[x, z - 1]);
                if (x > 0 && z > 0) InfectUnit(unit, units[x - 1, z - 1]);
                if (x > 0 && z < NUM_CELLS - 1) InfectUnit(unit, units[x - 1, z + 1]);
                unit = unit.Next;
            }
        }

        private static void InfectUnit(Unit unit, Unit other)
        {
            while (other != null)
            {
                if (Vector3.Distance(unit.transform.position,
                    other.transform.position) < 0.5f)
                {
                    unit.Infect(other);
                }
                other = other.Next;
            }
        }
    }
}


using UnityEngine;

namespace SpatialPartition
{
    public class Unit : MonoBehaviour
    {
        private Grid grid;
        private Vector3 destination;
        private bool infected;

        public Unit Prev;
        public Unit Next;

        public void Injection(Grid grid)
        {
            this.grid = grid;
        }

        private void Awake()
        {
            if (Random.value > 0.9f)
            {
                infected = true;
                GetComponent<Renderer>().material.color = Color.black;
            }
            else
            {
                infected = false;
                GetComponent<Renderer>().material.color = Color.red;
            }
            destination = GetRandomPosition();
        }

        private void Update()
        {
            if (Vector3.Distance(transform.position, destination) < 0.1f)
                destination = GetRandomPosition();
            grid.UpdateUnits(this);
        }

        public void Move()
        {
            transform.position = Vector3.MoveTowards(
                   transform.position, destination, Time.deltaTime);
        }

        public Vector3 GetRandomPosition()
        {
            return new Vector3(
                    Random.Range(0, 10f), 0, Random.Range(0, 10f));
        }

        public void Infect(Unit other)
        {
            if (infected == other.infected) return;
            if (infected)
            {
                other.infected = true;
                other.GetComponent<Renderer>().material.color = Color.black;
            }
            else
            {
                infected = true;
                GetComponent<Renderer>().material.color = Color.black;
            }
            
        }
    }
}

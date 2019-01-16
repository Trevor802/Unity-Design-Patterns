using UnityEngine;
using CommandPattern;

public class InputHandler : MonoBehaviour
{
    public GameObject Target;
    public int MaxReservedCommands;

    private Command[] commands;
    private int nextCommandIndex = 0; // TODO Use iterator to traverse commands
    private int stopUndoIndex = 0;
    private bool undoable;

    private void Awake()
    {
        commands = new Command[MaxReservedCommands];
    }

    private void Update()
    {
        HandleInput();
    }

    private void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Execute(new MoveUpCommand(Target.transform));
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Execute(new MoveDownCommand(Target.transform));
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Execute(new MoveLeftCommand(Target.transform));
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Execute(new MoveRightCommand(Target.transform));
        }
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            Undo();
        }
        else if (Input.GetKeyDown(KeyCode.Y))
        {
            Redo();
        }
    }

    public void Execute(Command command)
    {
        stopUndoIndex = nextCommandIndex;
        undoable = true;
        command.Execute();
        Debug.Log("Execute: " + command.GetType());
        commands[nextCommandIndex++] = command;
        if (nextCommandIndex >= MaxReservedCommands) nextCommandIndex = 0;
    }

    public void Undo()
    {
        if (!TryGetBackwardIndex(ref nextCommandIndex))
        {
            Debug.LogWarning("Cannot undo action.");
            return;
        }
        if (nextCommandIndex == stopUndoIndex) undoable = false;
        commands[nextCommandIndex].Undo(); 
    }

    public void Redo()
    {
        if (commands[nextCommandIndex] == null || undoable)
        {
            Debug.LogWarning("Cannot redo action");
            return;
        }
        if (nextCommandIndex == stopUndoIndex) undoable = true;
        commands[nextCommandIndex++].Execute();
        if (nextCommandIndex == MaxReservedCommands) nextCommandIndex = 0;
    }

    private bool TryGetBackwardIndex(ref int index) // TODO remove parameter
    {
        int origin = index;
        index--;
        if (index < 0)
        {
            index = MaxReservedCommands - 1;
            if (commands[index] == null)
            {
                index = 0;
                return false;
            }
        }
        if (index == stopUndoIndex && !undoable)
        {
            index = origin;
            return false;
        }
        return true;
    }

}

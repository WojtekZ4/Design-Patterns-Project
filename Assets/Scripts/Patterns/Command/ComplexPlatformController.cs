using System.Collections.Generic;
using UnityEngine;

public class ComplexPlatformController : MonoBehaviour
{
    public List<Command> commands = new List<Command>();
    List<Command>.Enumerator commandEnumerator;

    void Start()
    {
        commands.ForEach(command => command.enabled = false);
        commandEnumerator = commands.GetEnumerator();
        GetNextCommand();
        commandEnumerator.Current.Execute();
    }
    void GetNextCommand()
    {
        if (!commandEnumerator.MoveNext())
        {
            commandEnumerator = commands.GetEnumerator();
            commandEnumerator.MoveNext();
        }
    }

    void FixedUpdate()
    {
        if (commandEnumerator.Current.ComandComplete)
        {
            GetNextCommand();
            commandEnumerator.Current.Execute();
        }

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag.Equals("Player"))
        {
            other.gameObject.transform.SetParent(this.gameObject.transform);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.transform.parent != null && other.gameObject.transform.parent.Equals(this.gameObject.transform))
        {
            other.gameObject.transform.SetParent(null);
        }
    }
}

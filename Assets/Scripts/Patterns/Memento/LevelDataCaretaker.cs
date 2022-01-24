using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class LevelDataCaretaker : MonoBehaviour
{
    public LevelsContainer originator;

    private void Start()
    {
        originator = new LevelsContainer();
        LoadGameData();
    }
    public void LoadGameData()
    {
        string path = Application.persistentDataPath + "/levelData";
        if (File.Exists(path))
        {
            BinaryFormatter formater = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            originator.RestoreMemento(formater.Deserialize(stream) as LevelsMemento);
            stream.Close();
        }
        else
            SaveGameData();
    }

    public void SaveGameData()
    {
        BinaryFormatter formater = new BinaryFormatter();
        string path = Application.persistentDataPath + "/levelData";
        FileStream stream = new FileStream(path, FileMode.Create);
        formater.Serialize(stream, originator.CreateMemento());
        stream.Close();
    }
}

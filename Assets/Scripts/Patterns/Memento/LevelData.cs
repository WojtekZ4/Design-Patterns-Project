using System;

[Serializable]
public class LevelData
{
    public int ID;
    public string name;
    public bool unlocked;
    public int highScore;

    public LevelData(int ID)
    {
        this.ID = ID;
        this.name = "Level " + ID;
        this.unlocked = false;
        this.highScore = 0;
    }

    public LevelData(int ID, string name, bool unlocked, int highScore)
    {
        this.ID = ID;
        this.name = name;
        this.unlocked = unlocked;
        this.highScore = highScore;
    }
}

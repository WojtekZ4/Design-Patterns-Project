using System.Collections;
using System.Collections.Generic;

public class LevelsContainer : IteratorAggregate
{
    List<LevelData> levels;

    public LevelsContainer()
    {
        levels = new List<LevelData>
        {
            new LevelData(1),
            new LevelData(2),
            new LevelData(3),
            new LevelData(4)
        };

        UnlockLevel(1);
    }
    public LevelsMemento CreateMemento()
    {
        var memento = new LevelsMemento();
        memento.SetState(levels);
        return memento;
    }

    public void RestoreMemento(LevelsMemento toRestore)
    {
        levels = toRestore.GetState();
    }

    public LevelData GetLevelById(int ID)
    {
        return levels[ID - 1];
    }

    public bool HasNext(int ID)
    {
        return ID < levels.Count;
    }

    public void UnlockLevel(int ID)
    {
        levels[ID - 1].unlocked = true;
    }
    public void SetHighScore(int ID, int score)
    {
        levels[ID - 1].highScore = score;
    }

    public LevelData[] GetLevels()
    {
        return levels.ToArray();
    }

    public override IEnumerator GetEnumerator()
    {
        return new LevelsIterator(this);
    }
}
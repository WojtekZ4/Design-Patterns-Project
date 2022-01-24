using System;
using System.Collections.Generic;

[Serializable]
public class LevelsMemento
{
    private List<LevelData> levels;

    public List<LevelData> GetState()
    {
        return levels;
    }

    public void SetState(List<LevelData> levels)
    {
        this.levels = levels;
    }
}
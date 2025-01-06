using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLevel
{
    public void SaveLevelData(int maxLevel)
    {
        bool[] levels = LevelConverter(maxLevel);
        SaveSystem.SaveLevel(levels);
    }

    private bool[] LevelConverter(int maxLevel)
    {
        bool[] levelsArr = new bool[maxLevel + 1];
        for (int i = 0; i <= maxLevel; i++)
        {
            levelsArr[i] = true;
        }
        return levelsArr;
    }
}

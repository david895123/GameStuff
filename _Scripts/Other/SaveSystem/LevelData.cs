using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class LevelData
{
    public bool[] levels = new bool[11];


    public LevelData(bool[] levels)
    {
        this.levels = levels;
    }
}

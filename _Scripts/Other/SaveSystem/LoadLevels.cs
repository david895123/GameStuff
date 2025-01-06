using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLevels : MonoBehaviour
{
    private void Start()
    {
        LevelData data = SaveSystem.LoadLevelData();

        bool[] levels = data.levels;

        for (int i = 0; i < levels.Length; i++)
        {

        }
    }
}

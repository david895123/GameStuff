using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestSaveLeve : MonoBehaviour
{
    SaveLevel saveLevel;
    public int maxLevel;

    private void Start()
    {
        saveLevel = new SaveLevel();
        saveLevel.SaveLevelData(maxLevel);
    }
}

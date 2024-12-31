using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Developer : MonoBehaviour
{
    [SerializeField] private Player player;



    [MenuItem("Developer/TakeDamage")]

    public static void TakeDamage()
    {
        Debug.Log("Player took 10 damage");
    }
}

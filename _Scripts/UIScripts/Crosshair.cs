using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour
{
    Vector3 pos;

    void Update()
    {
        pos = Input.mousePosition;
        pos.z = 1;
        transform.position = Camera.main.ScreenToWorldPoint(pos);
    }
}

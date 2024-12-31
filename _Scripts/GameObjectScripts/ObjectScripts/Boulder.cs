using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boulder : Arrow
{
    [SerializeField] float rotateValue;



    // Update is called once per frame
    void Update()
    {
        float rotationThisFrame = rotateValue * Time.deltaTime;

        // Apply rotation on the Z-axis
        transform.Rotate(0, 0, rotationThisFrame);

    }
}

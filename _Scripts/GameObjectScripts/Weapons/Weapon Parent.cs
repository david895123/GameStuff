using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponParent : MonoBehaviour
{

    public Vector2 pointerPosition { get; set; }

    private void Update()
    {
        Vector2 directiion = (pointerPosition - (Vector2)transform.position).normalized;
        transform.right = directiion;

        Vector2 scale = transform.localScale;
        if (directiion.x < 0)
        {
            scale.y = -1;
        }
        else if (directiion.x > 0)
        {
            scale.y = 1;
        }

        transform.localScale = scale;



    }
}

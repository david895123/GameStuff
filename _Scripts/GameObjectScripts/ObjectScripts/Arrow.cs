using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : DamageOnCollide
{
    private float imune = 0.2f;
    private float startTime;
    protected override void Start()
    {
        base.Start();
        startTime = Time.time;

    }
    protected override void OnCollide(Collider2D collider)
    {
        if (collider.tag != "LightLevel1" && collider.tag != "LightLevel2" && collider.tag != "LightLevel3"
            && collider.tag != "LightLevel4" && collider.tag != "LightLevel5")
        {


            if (Time.time - startTime >= imune)
            {
                base.OnCollide(collider);

                GameObject.Destroy(gameObject);
            }
        }

    }
}



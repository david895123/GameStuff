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
    protected override void OnCollide(Collider2D collider, string tag)
    {




        if (Time.time - startTime >= imune)
        {
            if (tag == "Player" || tag == "Enemy" || tag == "Blocking")
            {
                base.OnCollide(collider, tag);

                GameObject.Destroy(gameObject);

            }
        }


    }
}



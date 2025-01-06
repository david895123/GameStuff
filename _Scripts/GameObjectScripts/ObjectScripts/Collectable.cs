using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : Collidable
{
    protected bool collected;

    protected override void OnCollide(Collider2D collider, string tag)
    {

        //checs if it collides with player
        if (tag == "Player")
        {
            OnCollect(collider);
        }
    }

    protected virtual void OnCollect(Collider2D player)
    {
        collected = true;
    }

}
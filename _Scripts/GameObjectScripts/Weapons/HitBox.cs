using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBox : Collidable
{
    [SerializeField] private int damageAmount;
    [SerializeField] private float pushForce;


    protected override void OnCollide(Collider2D collider)
    {

        if (collider.tag == "Actor")
        {




            Damage dmg = new Damage
            {
                damageAmount = damageAmount,
                origin = transform.position,
                pushForce = pushForce,


            };

            Enemy enemy = collider.GetComponent<Enemy>();
            enemy.ReceiveDamage(dmg);
            Destroy(gameObject);

        }

    }

}

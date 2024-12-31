using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageOnCollide : Collidable
{
    [SerializeField] float damageAmount;
    [SerializeField] float pushForce;

    protected override void Start()
    {
        base.Start();

    }

    /*protected override void Update()
    {
        base.Update();
    }
    */

    protected override void OnCollide(Collider2D collider)
    {
        Debug.Log(collider.tag);

        if (collider.gameObject.CompareTag("Player"))
        {

            Damage dmg = new Damage
            {
                damageAmount = damageAmount,
                origin = transform.position,
                pushForce = pushForce


            };
            Player player = collider.GetComponentInParent<Player>();
            player.ReceiveDamage(dmg);
        }

        if (collider.gameObject.CompareTag("Enemy"))
        {
            Damage dmg = new Damage
            {
                damageAmount = damageAmount,
                origin = transform.position,
                pushForce = pushForce


            };
            Enemy enemy = collider.GetComponentInParent<Enemy>();
            enemy.ReceiveDamage(dmg);
        }
    }
}

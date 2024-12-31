using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Charachter
{
    [SerializeField] GameObject player;
    [SerializeField] float followDistance;
    [SerializeField] float speed;
    [SerializeField] float damageAmount;
    [SerializeField] float pushForce;
    private void Update()
    {
        if (transform.position.x - player.transform.position.x <= followDistance)
        {
            MoveTowards();
        }
    }

    private void MoveTowards()
    {
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Damage dmg = new Damage
            {
                damageAmount = damageAmount,
                origin = transform.position,
                pushForce = pushForce


            };
            Player player = collision.GetComponentInParent<Player>();
            player.ReceiveDamage(dmg);

            GameObject.Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Collidable
{
    //is the current GameObject the player
    [SerializeField] private bool isPlayer;

    //data to send damage
    [SerializeField] private int damageAmount;
    [SerializeField] private float pushForce;


    public int weponLevel = 0;
    private SpriteRenderer spriteRenderer;

    //Swing
    private float cooldown = 0.5f;
    private float lastSwing;

    //
    private Animator animator;

    protected override void Start()
    {
        base.Start();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    /*protected override void Update()
    {
        base.Update();

    }
    */

    protected override void OnCollide(Collider2D collider)
    {
        Damage dmg = new Damage
        {
            damageAmount = damageAmount,
            origin = transform.position,
            pushForce = pushForce


        };

        if (collider.tag == "Player" && !isPlayer)
        {
            Player player = collider.GetComponentInParent<Player>();
            player.ReceiveDamage(dmg);
        }
        else if (collider.tag == "Actor" && isPlayer)
        {

            Enemy enemy = collider.GetComponent<Enemy>();
            enemy.ReceiveDamage(dmg); ;
        }


    }

    public void Swing()
    {

        if (Time.time - lastSwing > cooldown)
        {
            lastSwing = Time.time;
            animator.SetTrigger("Swing");
        }

    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charachter : MonoBehaviour
{
    [Header("Charachter stats")]
    //declaring hitpoints
    [SerializeField] public float hitpoint;
    [SerializeField] protected float maxHitpoints;
    [SerializeField] protected float pushRecoverySpeed = 0.2f;

    //declaring stamina



    //declating magic

    [SerializeField] protected float magic;
    [SerializeField] protected float maxMagic;

    //declaring damage negation percenteges
    [Space]
    protected float imuneTime = 0.2f;
    protected float lastImmune;

    protected Vector3 pushDirection;

    //--------------------------------------------------------------------------------------

    public virtual void ReceiveDamage(Damage dmg)
    {

        if (Time.time - lastImmune > imuneTime)
        {
            lastImmune = Time.time;

            //chechs for the specific damage type and applies damage negation
            hitpoint -= dmg.damageAmount;









            pushDirection = (transform.position - dmg.origin).normalized * dmg.pushForce;


            if (hitpoint <= 0)
            {
                hitpoint = 0;
                Death();
            }
        }
    }

    //--------------------------------------------------------------------------------------






    protected virtual void Death()
    {
        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : Collidable
{
    [SerializeField] private Sprite presssed;
    [SerializeField] private Sprite unPressed;
    [SerializeField] private bool oneUse;
    [SerializeField] private float resetTime;
    [SerializeField] private Projectile projectile;
    [SerializeField] UnityEngine.Quaternion rotation;
    private Collider2D trapCollider;
    private float lastTime;
    protected override void Start()
    {
        GetComponent<SpriteRenderer>().sprite = unPressed;
        trapCollider = GetComponent<Collider2D>();
        base.Start();

    }

    private void Update()
    {
        if (Time.time - lastTime >= resetTime && !oneUse)
        {
            GetComponent<SpriteRenderer>().sprite = unPressed;
            trapCollider.enabled = true;
        }

    }

    // Update is called once per frame
    protected override void OnCollide(Collider2D collider, string tag)
    {


        if (collider.gameObject.CompareTag("Player"))
        {
            trapCollider.enabled = false;
            if (!oneUse)
            {
                lastTime = Time.time;

            }
            projectile.Fire(rotation);
            GetComponent<SpriteRenderer>().sprite = presssed;

        }


    }
}

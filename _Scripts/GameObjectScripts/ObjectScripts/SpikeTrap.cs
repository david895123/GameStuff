using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeTrap : DamageOnCollide
{
    [SerializeField] private Sprite spikesHidden;
    [SerializeField] private Sprite spikesEngaged;
    [SerializeField] private float timeInterval;
    [SerializeField] private float offset;
    private Collider2D spikeCollider;
    private Collider2D playerCollider;
    private float lastTime;
    private bool engaged;
    private bool isColliding;

    protected override void Start()
    {
        spikeCollider = GetComponent<Collider2D>();
        GetComponent<SpriteRenderer>().sprite = spikesHidden;
        engaged = false;
        base.Start();
        lastTime = Time.time + offset;
        isColliding = false;
    }

    void Update()
    {
        if (Time.time - lastTime >= timeInterval)
        {
            lastTime = Time.time;
            if (engaged)
            {
                GetComponent<SpriteRenderer>().sprite = spikesHidden;
                engaged = false;
                spikeCollider.enabled = false;

            }
            else
            {
                GetComponent<SpriteRenderer>().sprite = spikesEngaged;
                engaged = true;
                spikeCollider.enabled = true;
                if (isColliding)
                {
                    OnCollide(playerCollider, playerCollider.gameObject.tag);
                }
            }
        }
    }



    protected override void OnCollide(Collider2D collider, string tag)
    {
        isColliding = true;
        playerCollider = collider;
        if (engaged)
        {
            base.OnCollide(collider, tag);


        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isColliding = false;
        }
    }
}

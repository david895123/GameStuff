using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Shadow : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] float speed;
    [SerializeField] float multiplier1;
    [SerializeField] float multiplier2;
    [SerializeField] float multiplier3;
    [SerializeField] float multiplier4;
    [SerializeField] float multiplier5;
    private float speedMultiplier = 1f;
    [SerializeField] float freeze;
    private float damageAmount = 100;
    private float pushForce = 0;
    private float startTime;
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if ((Time.time - startTime > freeze))
        {


            transform.Translate(Vector3.right * speed * Time.deltaTime * speedMultiplier);
            transform.position = new Vector3(transform.position.x, player.transform.position.y, 0);
        }
    }

    public void LightChange(float light)
    {
        float multiplier = 1 - (light / 1.5f);
        speedMultiplier = multiplier;

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

        }




    }


}

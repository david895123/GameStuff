using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPowerUp : PowerUps
{
    [SerializeField] float healAmount;

    protected override void OnCollect(Collider2D collider)
    {
        Player player = collider.GetComponentInParent<Player>();
        player.ReceiveHealth(healAmount);
        GameObject.Destroy(gameObject);
    }
}

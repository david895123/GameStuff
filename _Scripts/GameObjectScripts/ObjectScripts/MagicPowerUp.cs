using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicPowerUp : PowerUps
{
    [SerializeField] float magicAmount;

    protected override void OnCollect(Collider2D collider)
    {
        Player player = collider.GetComponentInParent<Player>();
        player.ReceiveMagic(magicAmount);
        GameObject.Destroy(gameObject);
    }
}

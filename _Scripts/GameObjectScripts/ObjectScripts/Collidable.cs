using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Collidable : MonoBehaviour
{

    public ContactFilter2D contactFilter;
    private PolygonCollider2D boxCollider;
    private Collider2D[] hits = new Collider2D[10];

    //Gets boxcolleder component of the gameobject
    protected virtual void Start()
    {
        boxCollider = GetComponent<PolygonCollider2D>();
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("Blocking") || collision.gameObject.CompareTag("Enemy"))
        {
            OnCollide(collision, collision.gameObject.tag);
        }

    }

    protected virtual void OnCollide(Collider2D collider, string tag)
    {
        Debug.Log("OnCollide was not implemeted in " + this.name);
    }
}

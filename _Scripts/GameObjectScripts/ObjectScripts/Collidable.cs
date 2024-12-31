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

    // Checs for collision
    /*protected virtual void Update()
    {
        boxCollider.OverlapCollider(contactFilter, hits);

        for (int i = 0; i < hits.Length; i++)
        {
            if (hits[i] == null)
            {
                continue;
            }

            OnCollide(hits[i]);

            hits[i] = null;

        }

    }
    */

    private void OnTriggerEnter2D(Collider2D collision)
    {

        OnCollide(collision);
    }

    protected virtual void OnCollide(Collider2D collider)
    {
        Debug.Log("OnCollide was not implemeted in " + this.name);
    }
}

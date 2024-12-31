using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Mover : Charachter
{

    [SerializeField] private BoxCollider2D movementCollider;
    [SerializeField] private BoxCollider2D hitbox;
    [SerializeField] private GameObject charachter;
    [SerializeField] private float movementSpeed;
    private Vector3 moveDelta;
    private RaycastHit2D hit;
    protected float ySpeed = 0.75f;
    protected float xSpeed = 1f;





    protected virtual void Start()
    {


    }


    public virtual void UpdateMotor(Vector3 input)
    {
        moveDelta = new Vector3(input.x * xSpeed, input.y * xSpeed, 0);

        moveDelta.Normalize();

        if (moveDelta.x > 0)
            transform.localScale = Vector3.one;
        else if (moveDelta.x < 0)
            transform.localScale = new Vector3(-1, 1, 1);


        //normalize input vector



        //add push vector
        moveDelta += pushDirection;


        //Reduce push force every frame, based off recovery speed
        pushDirection = Vector3.Lerp(pushDirection, Vector3.zero, pushRecoverySpeed);


        transform.Translate(0, moveDelta.y * Time.deltaTime * movementSpeed, 0);
        transform.Translate(moveDelta.x * Time.deltaTime * movementSpeed, 0, 0);

        //Make sure object can move in y direction if yes returns null
        /*
        hit = Physics2D.BoxCast(transform.position, movementCollider.size, 0, new Vector2(0, moveDelta.y), Mathf.Abs(moveDelta.y * Time.deltaTime), LayerMask.GetMask("Actor", "Blocking"));

        if (hit.collider == null)
        {
            transform.Translate(0, moveDelta.y * Time.deltaTime * movementSpeed, 0);

        }
        else
            Debug.Log(hit.rigidbody);


        //Make sure object can move in x direction if yes returns null

        hit = Physics2D.BoxCast(transform.position, movementCollider.size, 0, new Vector2(moveDelta.x, 0), Mathf.Abs(moveDelta.x * Time.deltaTime), LayerMask.GetMask("Actor", "Blocking"));

        if (hit.collider == null)
        {
            transform.Translate(moveDelta.x * Time.deltaTime * movementSpeed, 0, 0);

        }
        else
            Debug.Log("penisz");
        */
    }

}

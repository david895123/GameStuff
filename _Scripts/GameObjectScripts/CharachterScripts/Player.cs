using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class Player : Mover
{

    [SerializeField] private Projectile projectile;
    [SerializeField] private Weapon weapon;

    [SerializeField] private SetStatusBars setStatusBars;
    [SerializeField] private Quaternion rotation;
    private float currentHitpoints;
    private float currentMagic;
    private WeaponParent weaponParent;
    private PlayerControls playerControls;
    private Vector2 inputVec;

    Vector3 mousePos;
    protected override void Start()
    {
        setStatusBars.StartSetup(maxHitpoints, maxMagic);

        playerControls = new PlayerControls();
        weaponParent = GetComponentInChildren<WeaponParent>();


        currentHitpoints = hitpoint;
        currentMagic = magic;



        base.Start();
    }
    private void FixedUpdate()
    {
        CheckForChanges();
        UpdateMotor(new Vector3(inputVec.x, inputVec.y, 0));
        SetAim();
    }

    //----------------------------------------------------------------------------------

    private void OnAttack1()
    {
        Debug.Log("Attack2");
        projectile.Fire();
    }

    private void OnAttack2()
    {

    }

    private void OnSprint()
    {
        Debug.Log("Sprint");
    }

    private void OnInteract()
    {
        Debug.Log("Interact");
    }

    private void OnDodge()
    {
        Debug.Log("Dodge");
    }

    private void OnMove(InputValue input)
    {

        inputVec = input.Get<Vector2>();

    }

    private void OnAim(InputValue input)
    {

        Vector2 mousePosition = input.Get<Vector2>();
        mousePos = new Vector3(mousePosition.x, mousePosition.y, 0);

    }

    private void SetAim()
    {

        mousePos.z = Camera.main.nearClipPlane;
        weaponParent.pointerPosition = Camera.main.ScreenToWorldPoint(mousePos);

    }

    //-----------------------------------------------------------------------------------------------------

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Shadow"))
        {
        }
    }

    private void CheckForChanges()
    {
        if (currentHitpoints != hitpoint)
        {
            currentHitpoints = hitpoint;
            setStatusBars.SetHealthSlider(currentHitpoints);

        }
        if (currentMagic != magic)
        {
            currentMagic = magic;
            setStatusBars.SetMagicSlider(currentMagic);
        }


        if (setStatusBars.healthSlider.value != setStatusBars.easeHealthSlider.value)
        {
            setStatusBars.SetEaseHealthSlider(currentHitpoints);
        }

        if (setStatusBars.magicSlider.value != setStatusBars.easeMagicSlider.value)
        {
            setStatusBars.SetEaseMagicSlider(currentMagic);

        }
    }



}

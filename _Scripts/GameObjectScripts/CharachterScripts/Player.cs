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
        if (magic >= 5)
        {
            Debug.Log("Attack2");
            projectile.Fire();
            magic -= 5;
        }
    }


    private void OnAttack2()
    {

    }

    private void OnSprint()
    {
    }

    private void OnInteract()
    {
    }

    private void OnDodge()
    {
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

    private void OnEnable()
    {
        Ticker.OnTickAction02 += Tick;
    }

    private void OnDisable()
    {
        Ticker.OnTickAction02 -= Tick;
    }
    private void Tick()
    {
        Debug.Log("cica");
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

    public void ReceiveHealth(float amount)
    {
        if (hitpoint + amount > maxHitpoints)
        {
            hitpoint = maxHitpoints;
        }
        else
            hitpoint += amount;

    }
    public void ReceiveMagic(float amount)
    {
        if (magic + amount > maxMagic)
        {
            magic = maxMagic;
        }
        else
            magic += amount;

    }



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetStatusBars : MonoBehaviour
{
    public Slider healthSlider;
    public Slider easeHealthSlider;


    public Slider magicSlider;
    public Slider easeMagicSlider;

    [SerializeField] static float maxHitpoints;
    [SerializeField] static float maxMagic;

    private float fLerpSpeed = 0.05f;
    /// <summary>
    /// Setup for charachters which don't have magic and stamina (enemys, npcs, etc.)
    /// </summary>
    /// <param name="maxHealthValue">Maximum health of the Charachter</param>
    public void StartSetup(float maxHealthValue)
    {
        maxHitpoints = maxHealthValue;

        healthSlider.maxValue = maxHealthValue;
        healthSlider.value = maxHealthValue;

        easeHealthSlider.maxValue = maxHealthValue;
        easeHealthSlider.value = maxHealthValue;
    }

    /// <summary>
    /// Setup for charachters which have magic and stamina (player)
    /// </summary>
    /// <param name="maxHealthValue">Maximum health of the Charachter</param>
    /// <param name="maxStaminaValue">Maximum stamina of the Charachter</param>
    /// <param name="maxMagicValue">Maximum magic of the Charachter</param>
    public void StartSetup(float maxHealthValue, float maxMagicValue)
    {
        maxHitpoints = maxHealthValue;
        maxMagic = maxMagicValue;

        healthSlider.maxValue = maxHealthValue;
        healthSlider.value = maxHealthValue;

        easeHealthSlider.maxValue = maxHealthValue;
        easeHealthSlider.value = maxHealthValue;



        magicSlider.maxValue = maxMagicValue;
        magicSlider.value = maxMagicValue;

        easeMagicSlider.maxValue = maxMagicValue;
        easeMagicSlider.value = maxMagicValue;

    }

    /// <summary>
    /// Sets the healthSlider to health
    /// </summary>
    /// <param name="health">value representing the current health</param>
    public void SetHealthSlider(float health)
    {
        healthSlider.value = health;
    }

    /// <summary>
    /// Eases the health slider
    /// </summary>
    /// <param name="health"></param>
    public void SetEaseHealthSlider(float health)
    {
        easeHealthSlider.value = Mathf.Lerp(easeHealthSlider.value, health, fLerpSpeed);
    }




    /// <summary>
    /// Sets the magic slider to magic
    /// </summary>
    /// <param name="magic">Current magic value</param>
    public void SetMagicSlider(float magic)
    {
        magicSlider.value = magic;
    }

    /// <summary>
    /// Eases the magic slider
    /// </summary>
    /// <param name="magic"></param>
    public void SetEaseMagicSlider(float magic)
    {
        Debug.Log(magic);

        easeMagicSlider.value = Mathf.Lerp(easeMagicSlider.value, magic, fLerpSpeed);

    }
}

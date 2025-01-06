using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class FireFlicker : MonoBehaviour
{
    [SerializeField] Light2D Flame;
    [SerializeField] float intensity;
    [SerializeField] float falloff;
    [SerializeField] float speed;
    private float minFlicker;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float newIntensity = Mathf.Sin(Time.time * speed) * intensity / 1000;
        Flame.intensity += newIntensity;
        float newFalloff = Mathf.Sin(Time.time * speed) * falloff / 1000;
        Flame.falloffIntensity += newFalloff;
    }
}

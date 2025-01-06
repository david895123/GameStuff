using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Ticker : MonoBehaviour
{
    public static float tickTime02 = 0.2f;
    private float tickTimer02;

    public delegate void TickAction02();
    public static event TickAction02 OnTickAction02;

    public static float tickTime05 = 0.5f;
    private float tickTimer05;

    public delegate void TickAction05();
    public static event TickAction05 OnTickAction05;

    // Update is called once per frame
    void Update()
    {
        tickTimer02 += Time.deltaTime;
        if (tickTimer02 > tickTime02)
        {

            tickTimer02 = 0;
            TickEvent02();
        }

        tickTime05 += Time.deltaTime;
        if (tickTimer05 > tickTime05)
        {
            tickTimer05 = 0;
            TickEvent05();
        }
    }

    private void TickEvent02()
    {
        OnTickAction02?.Invoke();
    }

    private void TickEvent05()
    {
        OnTickAction05?.Invoke();
    }
}

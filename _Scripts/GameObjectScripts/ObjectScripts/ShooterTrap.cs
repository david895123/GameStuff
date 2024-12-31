using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterTrap : MonoBehaviour
{
    [SerializeField] private Projectile projectile;
    [SerializeField] private float timeInterval;
    [SerializeField] private float offset;
    [SerializeField] UnityEngine.Quaternion rotation;
    private float lastTime;

    private void Start()
    {
        lastTime = Time.time + offset;
    }

    private void Update()
    {
        if (Time.time - lastTime >= timeInterval)
        {
            projectile.Fire(rotation);
            lastTime = Time.time;
        }

    }
}

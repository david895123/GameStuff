using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] public GameObject projectilePrefab;
    [SerializeField] public Transform firePoint;
    [SerializeField] public float fireForce;

    public void Fire(UnityEngine.Quaternion rotation)
    {


        GameObject projectile = Instantiate(projectilePrefab, firePoint.position, rotation);
        projectile.GetComponent<Rigidbody2D>().AddForce(firePoint.right * fireForce, ForceMode2D.Impulse);
    }

    public void Fire()
    {


        GameObject projectile = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
        projectile.GetComponent<Rigidbody2D>().AddForce(firePoint.right * fireForce, ForceMode2D.Impulse);
    }
}

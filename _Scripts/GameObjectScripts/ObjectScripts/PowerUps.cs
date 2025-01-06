using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : Collectable
{
    [SerializeField] float height;
    [SerializeField] float speed;
    private float lastTime;
    private Vector3 startPos;

    protected override void Start()
    {
        startPos = transform.position;

    }
    // Update is called once per frame
    void Update()
    {
        float newY = Mathf.Sin(Time.time * speed) * height;
        transform.position = new Vector3(startPos.x, startPos.y + newY, startPos.z);

    }
}

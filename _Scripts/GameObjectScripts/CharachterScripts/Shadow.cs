using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Shadow : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] float speed;
    [SerializeField] float multiplier1;
    [SerializeField] float multiplier2;
    [SerializeField] float multiplier3;
    [SerializeField] float multiplier4;
    [SerializeField] float multiplier5;
    private float speedMultiplier = 1f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime * speedMultiplier);
        transform.position = new Vector3(transform.position.x, player.transform.position.y, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("collision");

        switch (collision.tag)
        {
            case "LightLevel1":
                speedMultiplier = multiplier1;
                break;
            case "LightLevel2":
                speedMultiplier = multiplier2;
                break;
            case "LightLevel3":
                speedMultiplier = multiplier3;
                break;
            case "LightLevel4":
                speedMultiplier = multiplier4;
                break;
            case "LightLevel5":
                speedMultiplier = multiplier5;
                break;

        }

    }


}

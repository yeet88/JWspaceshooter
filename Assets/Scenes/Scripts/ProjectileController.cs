using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    
    public float speed = 10;
    // Use this for initialization


    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y);
    }



    void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);    
    }
}

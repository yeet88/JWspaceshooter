using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject[] Hearts;
    
    public float movementSpeed = 3;

    public float hp = 10;
    public Transform firePoint;
    public GameObject projectile;

    public Canvas gameoverCanvas;


    // Use this for initialization
    void Start()
    {
        gameoverCanvas.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        float moveVert = Input.GetAxisRaw("Vertical") * movementSpeed * Time.deltaTime;

        transform.Translate(Vector3.up * moveVert, Space.World);
        shoot();

        death();

        removeHearts();
    }

    void shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectile, firePoint.position, firePoint.rotation);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.tag == "Enemy")
        {
            hp--;
        }
    }

    void death()
    {
        if (hp == 0)
        {
            Destroy(gameObject);
            gameoverCanvas.enabled = true;
        }
    }

    void removeHearts()
    {
        if(hp == 9)
        {
            Destroy(Hearts[0]);
        }

        if(hp == 8)
        {
            Destroy(Hearts[1]);
        }
        if (hp == 7)
        {
            Destroy(Hearts[2]);
        }

        if (hp == 6)
        {
            Destroy(Hearts[3]);
        }

        if (hp == 5)
        {
            Destroy(Hearts[4]);
        }
        if (hp == 4)
        {
            Destroy(Hearts[5]);
        }

        if (hp == 3)
        {
            Destroy(Hearts[6]);
        }
        if (hp == 2)
        {
            Destroy(Hearts[7]);
        }
        if (hp == 1)
        {
            Destroy(Hearts[8]);
        }
        if (hp == 0)
        {
            Destroy(Hearts[9]);
        }
    }
}

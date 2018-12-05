using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBase : MonoBehaviour
{

    public float speed;

    public int hp;

    // Use this for initialization
    protected virtual void Start()
    {

    }

    // Update is called once per frame
    protected virtual void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);

        death();

        if(transform.position.x < -10)
        {
            Destroy(gameObject);

        }
    }

    protected virtual void death()
    {
        if (hp < 1)
        {
            GameObject.FindWithTag("MainCamera").GetComponent<ScoreScript>().score += 1;
            Destroy(gameObject);
        }
    }

    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Projectile")
        {
            hp--;
        }
    }
}

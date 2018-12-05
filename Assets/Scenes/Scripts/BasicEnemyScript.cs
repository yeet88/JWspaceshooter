using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemyScript : EnemyBase
{
    [SerializeField]
    float frequency;

    [SerializeField]
    float amplitude;

    float timerr;

    protected override void Start()
    {
        base.Start();
        transform.position = new Vector3(transform.position.x, transform.position.y - 3);
    }



    protected override void Update()
    {
        base.Update();

        timerr += Time.deltaTime;

        Vector3 moveDistance = new Vector3(-(speed * Time.deltaTime), Mathf.Sin(timerr * frequency) * amplitude);
        transform.Translate(moveDistance, Space.World);
    }

}



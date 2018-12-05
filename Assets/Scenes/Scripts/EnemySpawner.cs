using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float minTime;
    public float maxTime;


    public ScoreScript scoreScript;

    public GameObject[] easyEnemies;

    public GameObject[] mediumEnemies;

    public float timer;

    public Vector2 spawnRange;
    // Use this for initialization
    void Start()
    {
        scoreScript = GetComponent<ScoreScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindWithTag("MainCamera").GetComponent<ScoreScript>().score >= 0 && GameObject.FindWithTag("MainCamera").GetComponent<ScoreScript>().score <= 20 && timer == 0)
        {
            SpawnEasyEnemy();
            minTime = 1.5f;
            maxTime = 2f;
        }

        coolDown();

        if (GameObject.FindWithTag("MainCamera").GetComponent<ScoreScript>().score >= 20 && GameObject.FindWithTag("MainCamera").GetComponent<ScoreScript>().score <= 25 && timer == 0)
        {
            SpawnEasyEnemy();
            SpawnMediumEnemy();
            minTime = 0.7f;
            maxTime = 1.3f;
        }

        if (GameObject.FindWithTag("MainCamera").GetComponent<ScoreScript>().score >= 25 && timer == 0)
        {
            SpawnEasyEnemy();
            SpawnMediumEnemy();
            minTime = 0.3f;
            maxTime = 0.9f;
        }



    }

    void coolDown()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            timer = Random.Range(minTime, maxTime);
            if (GameObject.FindWithTag("MainCamera").GetComponent<ScoreScript>().score >= 20)
            {
                SpawnMediumEnemy();
            }
            if (GameObject.FindWithTag("MainCamera").GetComponent<ScoreScript>().score >= 0)
            {
                SpawnEasyEnemy();
            }
        }


    }

    void SpawnEasyEnemy()
    {
        int selectEnemyType = Random.Range(0, easyEnemies.Length);

        Vector2 spawnPosition = new Vector2(transform.position.x, Random.Range(spawnRange.x, spawnRange.y));

        GameObject createdEnemy = Instantiate(easyEnemies[selectEnemyType]);
        createdEnemy.transform.position = spawnPosition;

        timer -= Time.deltaTime;
    }

    void SpawnMediumEnemy()
    {
        int selectEnemyType = Random.Range(0, mediumEnemies.Length);

        Vector2 spawnPosition = new Vector2(transform.position.x, Random.Range(spawnRange.x, spawnRange.y));

        GameObject createdEnemy = Instantiate(mediumEnemies[selectEnemyType]);

        createdEnemy.transform.position = spawnPosition;

        timer -= Time.deltaTime;

    }
}

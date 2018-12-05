using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : BasicEnemyScript
{

    public int score;

    public Text scoreText;

    public BasicEnemyScript enemyScript;

    public Canvas scoreCanvas;

    // Use this for initialization
    void Start()
    {
        enemyScript = GetComponent<BasicEnemyScript>();
        scoreCanvas.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}

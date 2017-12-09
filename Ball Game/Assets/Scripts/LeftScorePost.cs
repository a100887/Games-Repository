using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeftScorePost : MonoBehaviour {

    public int maxScore;
    public string nextLevel;
    public Text scoreP2Text;
    public static int highScoreP2 = 0;
    public static int scoreP2 = 0;
    public int increment;

    LevelManager levelManager = new LevelManager();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        scoreP2 = scoreP2 + increment;
        scoreP2Text.text = "Player 2 Score: " + scoreP2;

        if (scoreP2 >= maxScore)
        {
            highScoreP2 += scoreP2;
            RightScorePost.highScoreP1 += RightScorePost.scoreP1;
            scoreP2 = 0;
            RightScorePost.scoreP1 = 0;
            levelManager.LoadLevel(nextLevel);
        }
    }
}

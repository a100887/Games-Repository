using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeftScorePost : MonoBehaviour {

    LevelManager levelManager = new LevelManager();
    RightScorePost rightScorePost = new RightScorePost();

    public Text scoreP2Text;

    int scoreP2 = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        scoreP2++;
        scoreP2Text.text = "Player 2 Score: " + scoreP2;

        if (scoreP2 >= 5)
        {
            levelManager.LoadLevel("Level_02");
        }
    }
}

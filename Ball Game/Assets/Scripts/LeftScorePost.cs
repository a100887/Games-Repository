using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeftScorePost : MonoBehaviour {

    public int maxScore;
    public string nextLevel;
    public Text scoreP2Text;
    int scoreP2 = 0;

    LevelManager levelManager = new LevelManager();

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

        if (scoreP2 >= maxScore)
        {
            levelManager.LoadLevel(nextLevel);
        }
    }
}

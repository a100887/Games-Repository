using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RightScorePost : MonoBehaviour {

    LevelManager levelManager = new LevelManager();

    public Text scoreP1Text;
    int scoreP1 = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        scoreP1++;
        scoreP1Text.text = "Player 1 Score: " + scoreP1;

        if (scoreP1 >= 5)
        {
            levelManager.LoadLevel("Level_02");
        }
    }
}

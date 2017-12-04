using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RightScorePost : MonoBehaviour {

    public Text scoreP1Text;
    public string nextLevel;
    public int maxScore;
    int scoreP1 = 0;

    LevelManager levelManager = new LevelManager();

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

        if (scoreP1 >= maxScore)
        {
            levelManager.LoadLevel(nextLevel);
        }
    }
}

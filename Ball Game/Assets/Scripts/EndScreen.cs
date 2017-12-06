using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScreen : MonoBehaviour {

    public Text finalP1Score;
    public Text finalP2Score;
    public Text playerWon;
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        finalP1Score.text = "Player 1 score: " + RightScorePost.scoreP1;
        finalP2Score.text = "Player 2 score: " + LeftScorePost.scoreP2;
        
        if (LeftScorePost.scoreP2 > RightScorePost.scoreP1)
        {
            playerWon.text = "Player 2 won!";
        }

        else if (LeftScorePost.scoreP2 == RightScorePost.scoreP1)
        {
            playerWon.text = "It is a draw!";
        }

        else
        {
            playerWon.text = "Player 1 won!";
        }
    }
}

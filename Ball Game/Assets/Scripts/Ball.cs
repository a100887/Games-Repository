using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    Player_2 player2;
    Vector3 ballPaddleDiff;

    bool gameStarted = false;

    // Use this for initialization
    void Start () {

        player2 = GameObject.FindObjectOfType<Player_2>();
        ballPaddleDiff = this.transform.position - player2.transform.position;
    }
	
	// Update is called once per frame
	void Update () {

        if (!gameStarted) //if(gameStarted == false)
        {
            this.transform.position = player2.transform.position + ballPaddleDiff;
        }

        if (Input.GetMouseButtonDown(0) && !gameStarted) //The zero parameter is because the left mouse button is zero in unity
        {
            gameStarted = true;
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(-6f, 9f);
        }

    }
}

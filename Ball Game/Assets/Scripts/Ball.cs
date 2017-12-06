using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public float xSpeed;
    float ballDirection;
    Vector3 ballPos;
    bool gameStarted = false;

    // Use this for initialization
    void Start () {

        ballPos = gameObject.transform.position;
        ballDirection = xSpeed;
    }
	
	// Update is called once per frame
	void Update () {

        if (!gameStarted)
        {
            gameObject.transform.position = ballPos;
        }

        if (Input.GetMouseButtonDown(0) && !gameStarted)
        {
            gameStarted = true;
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(ballDirection, 9f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.gameObject.name == "RightScorePost")
        {
            gameStarted = false;
            ballDirection = xSpeed;
        }

        else if (collision.transform.gameObject.name == "LeftScorePost")
        {
            gameStarted = false;
            ballDirection = -xSpeed;
        }
    }
}

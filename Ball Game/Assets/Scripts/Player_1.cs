using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_1 : MonoBehaviour {

    private Rigidbody2D myRigidBody;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 newPlayer1Pos;

        if (Input.GetKey("up"))
        {
            newPlayer1Pos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 0.3f, gameObject.transform.position.z);
            gameObject.transform.position = newPlayer1Pos;
        }

        if (Input.GetKey("down"))
        {
            newPlayer1Pos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 0.3f, gameObject.transform.position.z);
            gameObject.transform.position = newPlayer1Pos;
        }

        

    }

}

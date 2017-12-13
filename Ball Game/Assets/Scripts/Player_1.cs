using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_1 : MonoBehaviour {

    float yPos = 0f;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetKey("up"))
        {
            yPos += 0.3f;
        }

        if (Input.GetKey("down"))
        {
            yPos -= 0.3f;
        }

        gameObject.transform.position = new Vector3(transform.position.x, yPos, transform.position.z);
        yPos = Mathf.Clamp(gameObject.transform.position.y, -3.99f, 3.99f);
    }
}

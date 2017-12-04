using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickBlock : MonoBehaviour {

    bool check = true;
    float startPos;

    // Use this for initialization
    void Start () {

        startPos = gameObject.transform.position.y;
    }
	
	// Update is called once per frame
	void Update () {

        if (gameObject.transform.position.y >= 0.5 && check == true)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 0.1f, gameObject.transform.position.z);
        }

        else
        {
            check = false;
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 0.1f, gameObject.transform.position.z);
        }

        if (gameObject.transform.position.y >= startPos)
        {
            check = true;
        }

    }
}

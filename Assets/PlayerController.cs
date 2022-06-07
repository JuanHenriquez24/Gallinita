using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position = new Vector3(3.3f, 2f, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position = new Vector3(3.3f, 0.5f, 0);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileEmpty : MonoBehaviour {

    public GameObject prefab;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float currentTime = Time.time;
        while (currentTime < 10)
        {
            Debug.Log("Esta saliendo un mensaje, pero no por mucho");
        }
	}
}

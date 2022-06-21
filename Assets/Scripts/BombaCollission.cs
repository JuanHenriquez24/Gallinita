using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombaCollission : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "tren")
        {
            Destroy(gameObject);
        }
        if (col.gameObject.name == "tren(Clone)")
        {
            Destroy(gameObject);
        }
        if (col.gameObject.name == "tren 1")
        {
            Destroy(gameObject);
        }
        if (col.gameObject.name == "tren 1(Clone)")
        {
            Destroy(gameObject);
        }
        if (col.gameObject.name == "Deepnest")
        {
            Destroy(gameObject);
        }
    }
}

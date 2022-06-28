using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrenOEnemigo : MonoBehaviour {

   
    public float speed;
    public float maxSpeed;
    public float minspeed;
    // Use this for initialization
    void Start()
    { 
    }

	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Bomba 1(Clone)")
        {
            Destroy(gameObject);
        }
        if (col.gameObject.name == "Deepnest")
        {
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileEmpty : MonoBehaviour {

    public GameObject prefab;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	public void CloneObject () {
        GameObject clon;
        for (int i=0;i<300;i++)
        { 
            clon = Instantiate(prefab);
            clon.transform.Rotate(0, 45 * i, 0);
            clon.transform.Translate(i*.3f,i,0);
            
            //Destroy(clon,.5f);
        }
	}
}

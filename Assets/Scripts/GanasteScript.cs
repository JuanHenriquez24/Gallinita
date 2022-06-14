using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GanasteScript : MonoBehaviour {

    public Canvas pantalla;
    public GameObject player;
	// Use this for initialization
	void Start () {
        pantalla.enabled = !enabled;
	}
	
	// Update is called once per frame
	void Update () {
		if (player.transform.position.z <= -136)
        {
            pantalla.enabled = enabled;
        }
	}
}

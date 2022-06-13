using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileEmpty : MonoBehaviour {

    public GameObject prefab;

    // Use this for initialization
    void Start () {
        float contador = 0;
        while (contador < 10)
        {
            Debug.Log("Esta saliendo un mensaje, pero no por mucho");
            contador++;
        }
    }
	
	// Update is called once per frame
	void Update () {
        float currentTime = Time.time;
    }
}

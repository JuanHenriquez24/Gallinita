using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour {

    public AudioClip Espacio;
    AudioSource fuenteAudio;

	// Use this for initialization
	void Start () {
        fuenteAudio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
            {
            fuenteAudio.clip = Espacio;
            fuenteAudio.Play();
        }
	}
}

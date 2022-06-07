using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {
    public AudioClip Muerte;
    public AudioSource fuenteAudio;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Helice")
        {
            fuenteAudio.clip = Muerte;
            fuenteAudio.Play();
            Destroy(gameObject);
        }
    }
}

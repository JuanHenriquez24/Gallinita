using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {
    public AudioClip Muerte;
    public AudioSource fuenteAudio;
    public GameObject cam;

    // Use this for initialization
    void Start () {
        cam = GetComponentInChildren<Camera>().gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Tren")
        {
            cam.transform.parent = null;
            fuenteAudio.clip = Muerte;
            fuenteAudio.Play();
            Destroy(gameObject);
        }
        if (col.gameObject.name == "Deepnest")
        {
            cam.transform.parent = null;
            fuenteAudio.clip = Muerte;
            fuenteAudio.Play();
            Destroy(gameObject);
        }
        if (col.gameObject.name == "Tren(Clone)")
        {
            cam.transform.parent = null;
            fuenteAudio.clip = Muerte;
            fuenteAudio.Play();
            Destroy(gameObject);
        }
    }
}

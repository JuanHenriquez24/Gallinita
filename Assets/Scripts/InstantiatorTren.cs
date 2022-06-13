using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiatorTren : MonoBehaviour {

    public Helixbehavior trenp;
    public float speed;
    public float maxSpeed;
    public float minspeed;
    // Use this for initialization
    void Start()
    {
        float R = Random.Range(0, 10);
        Helixbehavior helix = Instantiate(trenp, transform.position, transform.rotation);
        helix.speed = R;
        speed = Random.Range(minspeed, maxSpeed);
    }

    // Update is called once per frame
    void Update () {
		
	}
}

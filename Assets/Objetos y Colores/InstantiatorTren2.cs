using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiatorTren2 : MonoBehaviour
{

    public Helixbehavior trenp;
    public GameObject bomb;
    GameObject clon;
    public float timebetweenbombs;
    public GameObject spawnPoint;
    float timer;

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
        timer = timebetweenbombs;
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer - Time.deltaTime;
        if (timer <= 0)
        {
            clon = Instantiate(bomb);
            timer = timebetweenbombs;
            clon.transform.position = spawnPoint.transform.position - spawnPoint.transform.forward;
        }
    }
}

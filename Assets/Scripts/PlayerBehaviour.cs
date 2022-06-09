using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour {

    public GameObject bala;
    public GameObject spawnPoint;
    public Transform apuntadorTR;
    Rigidbody rbBala;

    public float fuerzaDisparo;

    // Use this for initialization
    void Start ()
    {

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Q))
        {

            GameObject clon;
            clon = Instantiate(bala);
            rbBala = clon.GetComponent<Rigidbody>();
            clon.transform.rotation = apuntadorTR.rotation;
            clon.transform.position = spawnPoint.transform.position - spawnPoint.transform.forward;
            rbBala.AddForce(clon.transform.up * fuerzaDisparo, ForceMode.Impulse);
            rbBala.AddForce(apuntadorTR.up * fuerzaDisparo, ForceMode.Impulse);
            /*
            GameObject clon;
            clon = Instantiate(bomba);
            clon.transform.position = spawnPoint.transform.position - spawnPoint.transform.forward;
            clon.transform.rotation = apuntadorTR.rotation;
            prefab.AddForce(clon.transform.up * fuerzaDisparo, ForceMode.Impulse);
            */
        }
	}
}

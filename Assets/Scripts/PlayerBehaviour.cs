using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour {

    public GameObject bomba;
    public GameObject spawnPoint;
    public Transform apuntadorTR;
    Rigidbody prefab;

    public float fuerzaDisparo;

    // Use this for initialization
    void Start () {
        prefab = prefab.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Q))
        {
            prefab.AddForce(apuntadorTR.up * fuerzaDisparo, ForceMode.Impulse);
            GameObject clon;
            clon = Instantiate(bomba);
            clon.transform.rotation = apuntadorTR.rotation;
            prefab.AddForce(clon.transform.up * fuerzaDisparo, ForceMode.Impulse);
            clon.transform.position = spawnPoint.transform.position - spawnPoint.transform.forward;
        }
	}
}

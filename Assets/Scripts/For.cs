using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class For : MonoBehaviour
{
    public GameObject prefab;
    public GameObject spawnPoint;
    public int num1;
    private float contador;
    public int tiempoDelay;

    public void CloneObject()
    {
       for (int i = num1; i > 0; i--)
       {
            GameObject clon;
            clon = Instantiate(prefab);
            clon.transform.position = spawnPoint.transform.position - spawnPoint.transform.forward;
        }
    }


    private void Update()
    {
        contador += Time.deltaTime;
        if (contador >= tiempoDelay)
        {
            contador = 0;
            CloneObject();
        }
    }
}
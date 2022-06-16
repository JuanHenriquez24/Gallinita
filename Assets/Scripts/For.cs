using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class For : MonoBehaviour
{
    public GameObject prefab;


    public void CloneObject()
    {
        GameObject clon;
        if (Input.GetKeyDown(KeyCode.P))
        {
            for (int i = 0; i < 300; i++)
            {
                clon = Instantiate(prefab);
                clon.transform.Rotate(0, 45 * i, 0);
                clon.transform.Translate(i * .3f, i, 0);

                //Destroy(clon,.5f);
            }
        }

    }
}
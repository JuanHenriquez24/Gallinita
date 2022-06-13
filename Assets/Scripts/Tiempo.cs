using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tiempo : MonoBehaviour
{

    public Text txtTime;
    public Text txtTimeFloored;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float currentTime = Time.time;

        txtTime.text = currentTime.ToString();

        txtTimeFloored.text = Mathf.Floor(currentTime).ToString();
    }
}
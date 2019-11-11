using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class timer : MonoBehaviour
{
    // Start is called before the first frame update
	public Transform player;
double timee = 80;
	public Text timerr;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     timee = Math.Max(0,timee-0.02);
     timerr.text = timee.ToString("0");
    }

}

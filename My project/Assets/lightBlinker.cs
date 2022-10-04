using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightBlinker : MonoBehaviour
{
    private Light myLight;
    public float timeMin;
    public float timeMax;
    private float changeTime;
    // Start is called before the first frame update
    void Start()
    {
        myLight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
       if (Time.time > changeTime)
       {
        GetComponent<Light>().enabled = !GetComponent<Light>().enabled;
        if (GetComponent<Light>().enabled)
        {
            changeTime = Time.time + Random.Range(timeMin, timeMax);
        }
        else
        {
            changeTime = Time.time + Random.Range(timeMin, timeMax);
        }
       }
    }
}

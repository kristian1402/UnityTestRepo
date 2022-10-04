using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class batteryLevel : MonoBehaviour
{
    public Flashlight Flashlight;
    public Image batteryImage;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float batteryTimer = Flashlight.timer/10;
        Debug.Log(batteryTimer);
        batteryImage.fillAmount = batteryTimer;
    }
}

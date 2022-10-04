using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    private Light spotlight;
    private bool timerIsRunning = true;
    public float timer;
    
    void Start()
    {
        spotlight = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        spotlight.intensity = 0f;

        if (Input.GetMouseButton(0)){
            if (timerIsRunning){
                if (timer > 0){
                    spotlight.intensity = 100f;
                    timer -= Time.deltaTime;
                    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            
                    if(Physics.Raycast(ray, out hit))
                    {
                        transform.LookAt(new Vector3(hit.point.x, hit.point.y, hit.point.z));
                    }
                }
                else{
                    spotlight.intensity = 0f;
                    Debug.Log("No more battery!");
                    timer = 0;
                    timerIsRunning = false;
                }
            }
        }
    }
}

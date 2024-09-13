using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float TimeLeft;
    public bool TimerOn = false;

    // Start is called before the first frame update
    void Start()
    {
        TimerOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(TimerOn){
            if(TimeLeft>0){
                TimeLeft -= Time.deltaTime;
                updateTimer(TimeLeft);
            }
            else{
                Debug.Log("Time's up!");
                TimeLeft = 0;
                TimerOn = false;
            }
        }
    }
    void updateTimer(float currentTime){
        currentTime += 1;
        float minutes = Mathf.FloorToInt(currentTime/60);
        float seconds = Mathf.FloorToInt(currentTime%60);
    }
}

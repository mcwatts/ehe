using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour{
    public float timeValue = 90;
    public Text timeText;
    public string nextScene;

    void Update(){
        if (timeValue > 0){
            timeValue -= Time.deltaTime;
        }
        else{
            timeValue = 0;
        }
        DisplayTime(timeValue);
    }

    void DisplayTime(float timeToDisplay){
        if(timeToDisplay < 0){
            timeToDisplay = 0;
            SceneManager.LoadScene(nextScene);
        }
        else if(timeToDisplay > 0){
            timeToDisplay += 1;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("Timer: {0:00}:{1:00}", minutes, seconds);
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

// The inspiration and solution for this script in terms of the code can be found here: https://www.youtube.com/watch?v=qe8MCWsGthM&ab_channel=LearnEverythingFast
// It has been slightly tailored and modified in a way that suits the needs of the game at hand

public class CountDownTimer : MonoBehaviour
{
    int countDownStartValue = 120;
    public TextMeshProUGUI txtTimerUI;
    
    // Start is called before the first frame update
    void Start()
    {
        countDownTimer();
    }

    void countDownTimer()
    {
        if (countDownStartValue > 0)
        {
            TimeSpan spanTime = TimeSpan.FromSeconds(countDownStartValue);
            txtTimerUI.text = "Timer " + spanTime.Minutes + ":"+ spanTime.Seconds;
            countDownStartValue--;
            Invoke("countDownTimer", 1.0f);
        }
        else
        {
            Debug.Log("Game Over");
            CancelInvoke("countDownTimer");
            SceneManager.LoadScene("GameOverScene");
        }
    }

}

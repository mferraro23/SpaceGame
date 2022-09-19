using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameTimer : MonoBehaviour
{
    public TMP_Text TimerText;

    float timeLeft = 60.0f;

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if(timeLeft <= 0)
        {
            SceneManager.LoadScene("Lose");
        }

        string temp = timeLeft.ToString("0.0");
        TimerText.text = string.Format("{0,0} S", temp);
    }
}

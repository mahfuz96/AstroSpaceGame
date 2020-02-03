using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerControl : MonoBehaviour
{
    void Update()
    {
        if (TimerScript.timeLeft <= 0)
        {
            SceneManager.LoadScene(2);
        }
    }
}

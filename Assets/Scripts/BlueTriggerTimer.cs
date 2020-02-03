using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueTriggerTimer : MonoBehaviour
{    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Blue"))
            TimerScript.timeLeft += 3f;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    public float move_speed = 5f;
    public float bound_X = -22f;

    public bool platform_Red, platform_Blue;

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        Vector2 temp = transform.position;
        temp.x -= move_speed * Time.deltaTime;
        transform.position = temp;

        if (temp.x <= bound_X)
        {
            gameObject.SetActive(false);
        }
    }
}

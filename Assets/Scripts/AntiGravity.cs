using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiGravity : MonoBehaviour
{
    private Rigidbody2D rigidbody2d;
    private bool ceiling;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            rigidbody2d.gravityScale *= -1;
            Rotation();
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            rigidbody2d.gravityScale *= -1;
            Rotation();
        }
    }

    void Rotation()
    {
        if(ceiling == false)
        {
            transform.eulerAngles = new Vector3(0, 0, 0f);
        } else
        {
            transform.eulerAngles = Vector3.zero;
        }
        ceiling = !ceiling;
    }
}

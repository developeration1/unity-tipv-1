using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToRight : MonoBehaviour
{
    [SerializeField] bool movingRight = true;
    [SerializeField] float speed;

    // Update is called once per frame
    void FixedUpdate()
    {
        /*
        if (movingRight)
        {
            transform.Translate(new Vector2(speed, 0));
        }
        else
        {
            transform.Translate(new Vector2(-speed, 0));
        }
        */
        transform.Translate(new Vector2(movingRight ? speed : -speed, 0));
    }
}

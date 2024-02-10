using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTriggerEnter : MonoBehaviour
{
    [SerializeField] string effectTag;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == effectTag)
        {
            Destroy(gameObject);
        }
    }
}

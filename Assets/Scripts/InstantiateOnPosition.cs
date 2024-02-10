using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateOnPosition : MonoBehaviour
{
    [SerializeField] GameObject prefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            transform.position = new Vector2(Random.Range(-8f, 8f), Random.Range(-4, 4));
            Instantiate(prefab, transform.position, Quaternion.identity);
        }
    }
}

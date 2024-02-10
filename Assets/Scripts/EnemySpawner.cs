using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] float minPos;
    [SerializeField] float maxPos;

    void Start()
    {
        InvokeRepeating("Spawn", 2, 2);
    }

    void Spawn()
    {
        Instantiate(enemy, transform.position, Quaternion.identity);
        transform.position = new Vector2(transform.position.x, Random.Range(minPos, maxPos));
    }
}

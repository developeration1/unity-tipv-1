using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] GameObject projectile;
    [SerializeField] Transform spawnPoint;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(projectile, spawnPoint.position, Quaternion.identity);

        }
    }
}

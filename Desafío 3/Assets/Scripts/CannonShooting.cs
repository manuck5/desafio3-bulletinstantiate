using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonShooting : MonoBehaviour
{
    public GameObject bullet;
    public Vector3 spawnPoint = new Vector3(0f, 0.881f, -0.11f);

    void Start()
    {
        Invoke("Shoot", 2.5f);
    }

    void Update()
    {
        
    }

    private void Shoot()
    {
        Instantiate(bullet, spawnPoint, transform.rotation);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //Variables
    public float speed = 25f;
    public float damage = 10f;

    public Vector3 direction = Vector3.forward;

    void Start()
    {
        
    }

    void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.position += direction * speed * Time.deltaTime;
    }
}

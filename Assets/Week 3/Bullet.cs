using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 5;
    public bool hasFired = false;
    void Update()
    {
        if (hasFired == true)
        {
            bulVelo();
        }
        else {
        PointAtMouse();
        }
    }

    void PointAtMouse()
    {
        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouse.z = 0;
        Vector2 direction = mouse - transform.position;

        transform.up = direction;
    }

    void bulVelo()
    {
        transform.position = (Vector2)transform.position + (Vector2)transform.up * speed * Time.deltaTime;
    }
}

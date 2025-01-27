using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spMove : MonoBehaviour
{
    //Using elements of my first script (movement constraint within world space)
    [Range(-5, 5)]
    public float mSpeed = 2.5f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;

        pos.x += mSpeed * Time.deltaTime;
        transform.position = pos;

        if (pos.x < -1)
        {
            mSpeed = mSpeed * -1;
        }
        else if (pos.x > 0.8f)
        {
            mSpeed = mSpeed * -1;
        }

    }
}

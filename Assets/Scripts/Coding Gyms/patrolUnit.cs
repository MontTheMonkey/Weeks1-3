using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patrolUnit : MonoBehaviour
{
    public Vector3[] patrolPoints = new Vector3[4];
    public float time = 0.5f;
    bool moveAtoB;
    // Start is called before the first frame update
    void Start()
    {
        patrolPoints[0] = new Vector3(0, 0, 0);
        patrolPoints[1] = new Vector3(3, 1, 0);
        Debug.Log("Patrol point A is " + patrolPoints[0]);
        Debug.Log("Patrol point B is " + patrolPoints[1]);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 output = Vector3.Lerp(patrolPoints[0], patrolPoints[1], time);
        if (moveAtoB)
        {
            time += Time.deltaTime;
            if (transform.position == patrolPoints[1])
            {
                moveAtoB = false;
            }
        }
        else
        {
            time -= Time.deltaTime;
            if (transform.position == patrolPoints[0])
            {
                moveAtoB = true;
            }
        }
        transform.position = output;
        Debug.Log(output);
        //Vector3 desPoint = patrolPoints[1] - patrolPoints[0];
        //Vector3 desPoint2 = patrolPoints[0] - patrolPoints[1];
        //Debug.Log("Patrol point B to A difference is " + desPoint);
        //Debug.Log("Patrol point A to B difference is " + desPoint2);
        //if (transform.position == patrolPoints[0])
        //{
        //    transform.position = transform.position + desPoint * speed;
        //}
        //if (transform.position == patrolPoints[1])
        //{
        //    transform.position = transform.position + desPoint2 * speed;
        //}
    }
}

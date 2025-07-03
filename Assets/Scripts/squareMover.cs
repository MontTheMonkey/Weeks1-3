using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class squareMover : MonoBehaviour
{
    public float sqrSpeed = 0.05f;
    float xMin = -8.65f;
    float xMax = 8.65f;

    // Start is called before the first frame update
    void Start()
    {   
        //Vector3 sqrPushR = transform.position + Vector3.right * 3.5f;
        //transform.position = sqrPushR;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 sqrPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        sqrPos.x = sqrPos.x + sqrSpeed;
        transform.position = sqrPos;
        //Checks if it reached the edge, if so increase the speed by 0.01f
        if (transform.position.x > xMax || transform.position.x < xMin)
        {
            if (sqrSpeed < 0){
                sqrSpeed = sqrSpeed - 0.01f;
            }
            else
            {
                sqrSpeed = sqrSpeed + 0.01f;
            }
            sqrSpeed = sqrSpeed * -1f;
        }
    }
}

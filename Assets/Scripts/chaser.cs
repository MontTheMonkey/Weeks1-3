using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chaser : MonoBehaviour
{
    public Vector3 newPosition;
    public Camera igCam;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        newPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosWS = igCam.ScreenToWorldPoint(Input.mousePosition);
        mousePosWS.z = 0f;
        //transform.position = mousePosWS;
        Vector3 origin = transform.position;
        Vector3 target = mousePosWS;
        Vector3 dirToMove = target - origin;
        //if (Input.GetKey(KeyCode.Mouse0) == true)
        //{
        //    transform.position = mousePosWS;
        //}
        if (Input.GetKey(KeyCode.Mouse0) == true){
            transform.position = transform.position + dirToMove * speed;
        }
        if (Input.GetKey(KeyCode.Mouse1) == true)
        {
            transform.position = transform.position + dirToMove * - speed;
        }


    }
}

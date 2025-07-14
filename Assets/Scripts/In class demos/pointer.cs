using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointer : MonoBehaviour
{
    public Vector3 mousePosWS;
    public Camera igCam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosWS = igCam.ScreenToWorldPoint(Input.mousePosition);
        Vector3 origin = transform.position;
        Vector3 target = mousePosWS;
        Vector2 pointFacing = target - origin;
        //Sets the Y value to face towards the cursors position
        transform.up = pointFacing;
    }
}

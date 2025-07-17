using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chaser : MonoBehaviour
{
    public SpriteRenderer sqRender;
    public Vector3 newPosition;
    public Camera igCam;
    public float speed;
    Vector3 mousePosWS;
    bool xMaxExceeded, yMaxExceeded;

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
        bool xMaxExceeded = Input.mousePosition.x > Screen.width;
        bool yMaxExceeded = Input.mousePosition.y > Screen.height;
        Debug.Log("X max exceeded = " + xMaxExceeded.ToString());
        Debug.Log("Y max exceeded = " + yMaxExceeded.ToString());
        bool xMinExceeded = Input.mousePosition.x < 0;
        bool yMinExceeded = Input.mousePosition.y < 0;
        Debug.Log("X min exceeded = " + xMinExceeded.ToString());
        Debug.Log("Y min exceeded = " + yMinExceeded.ToString());
        Vector3 origin = transform.position;
        Vector3 target = mousePosWS;
        Vector3 dirToMove = target - origin;


        //if (Input.GetKeyDown(KeyCode.Mouse0) == true)
        //{
        //    transform.position = mousePosWS;
        //}

        //Left click follows the cursor, right click repels negative speed away from the cursors position
        if (Input.GetKey(KeyCode.Mouse0) == true){
            transform.position = transform.position + dirToMove * speed;
        }
        if (Input.GetKey(KeyCode.Mouse1) == true)
        {
            transform.position = transform.position + dirToMove * - speed;
        }

        //If the X or Y position of the cursor is outside the maximum screen spaces, it sets the colour to yellow
        if (xMaxExceeded || yMaxExceeded)
        {
            sqRender.color = Color.yellow;
        }
        else
        {
            sqRender.color = Color.black;
        }
    }
}

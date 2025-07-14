using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clockHand : MonoBehaviour
{
    public float speed = 0.5f;
    float mSpeed;
    bool spinClock;
    Vector3 clockRotation;
    public SpriteRenderer clockColour;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mSpeed = speed * 12;
        if (Input.GetKey(KeyCode.Space))
        {
            spinClock = true;
        }
        if (Input.GetKey(KeyCode.Backspace))
        {
            spinClock = false;
        }
        // if (Input.GetKeyUp(KeyCode.Space) && spinClock == true)
        // {
        //     spinClock = false;
        // }
        if (spinClock == true)
        {
            clockRotation.z += speed;
            if (clockColour.color == Color.red)
            {
                clockRotation.z += mSpeed;
            }
        }
        Debug.Log("Spacebar pressed is " + Input.GetKey(KeyCode.Space));
        Debug.Log("Clock rotation is " + spinClock);
        transform.eulerAngles = clockRotation;
    }
}

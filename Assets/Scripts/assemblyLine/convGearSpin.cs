using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class convGearSpin : MonoBehaviour
{
    Vector3 objRotation;
    bool startLine;
    //Public variable to control the speed of rotation
    public float gearSpeed = 25f;
    //Gear sprite is from Adobe Stock (AdobeStock_558272801)
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            startLine =! startLine;
        }
        if (startLine == true)
        {
            //Using a public variable to control the speed, gears spin continuously while the variable startLine is true
            objRotation.z += gearSpeed * Time.deltaTime;
        }
        transform.eulerAngles = objRotation;
        
    }
}

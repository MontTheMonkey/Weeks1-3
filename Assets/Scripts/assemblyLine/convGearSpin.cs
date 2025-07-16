using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class convGearSpin : MonoBehaviour
{
    Vector3 objRotation;
    bool startLine;
    public float gearSpeed = 25f;
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
            objRotation.z += gearSpeed * Time.deltaTime;
        }
        transform.eulerAngles = objRotation;
        
    }
}

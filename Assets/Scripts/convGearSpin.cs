using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class convGearSpin : MonoBehaviour
{
    Vector3 objRotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        objRotation.z = 1;
        transform.eulerAngles += objRotation;
        if (Input.GetKey(KeyCode.Space) == true)
        {
            transform.eulerAngles -= objRotation;
        }
    }
}

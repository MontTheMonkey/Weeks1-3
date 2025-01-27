using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spmRotate : MonoBehaviour
{
    //The value of the stars rotation
    [Range(-30, 30)]
    public float rotaValue = 15f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 zRotate = transform.eulerAngles;
        zRotate.z += rotaValue * Time.deltaTime;
        transform.eulerAngles = zRotate;
        //When it reaches the end point of rotation, revert back the other way to reach the other end point (-30 Z value)
        if (zRotate.z > 30) {
            zRotate.z = 30;
            rotaValue = rotaValue * -1;
        }
        //When it reaches -30 Z value, rotate towards 30 Z value)
        if (zRotate.z < -30)
        {
            zRotate.z = -30;
            rotaValue = rotaValue * -1;
        }
    }
}

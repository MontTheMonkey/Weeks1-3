using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spmRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 zRotate = transform.eulerAngles;
        zRotate.z += 0.5f;
        transform.eulerAngles = zRotate;
    }
}

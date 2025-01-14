using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spmRotate : MonoBehaviour
{
    public float hourHand = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 zRotate = transform.eulerAngles;
        zRotate.z += hourHand;
        transform.eulerAngles = zRotate;
    }
}

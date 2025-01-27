using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spmRotate : MonoBehaviour
{
    [Range(-1.5f, 1.5f)]
    public float rotaValue = 0.5f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 zRotate = transform.eulerAngles;
        zRotate.z += rotaValue;
        transform.eulerAngles = zRotate;
        if (zRotate.z > 1.5) {
            zRotate.z = zRotate.z - 1 * Time.deltaTime;
        }
        if (zRotate.z < -1.5)
        {
            zRotate.z = zRotate.z - 1 * Time.deltaTime;
        }
    }
}

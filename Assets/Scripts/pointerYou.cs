using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class pointerYou : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cursorPosFollow = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        cursorPosFollow.z = 0;
        transform.up = cursorPosFollow;
    }
}

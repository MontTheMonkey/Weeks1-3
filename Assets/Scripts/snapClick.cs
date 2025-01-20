using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class snapClick : MonoBehaviour
{
    public Vector2 mousePosF;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            mousePosF = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = mousePosF;
            //transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition); <Trial
            //transform.position.z = 0; <Trial
        }
    }
}

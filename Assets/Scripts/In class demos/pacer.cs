using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pacer : MonoBehaviour
{
    public float speed = 0.05f;
    Camera gameCam;
    int direction = 1;
    // Start is called before the first frame update
    void Start()
    {
        gameCam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * speed * direction;
        Vector3 pacerPos = gameCam.WorldToScreenPoint(transform.position);
        //Debug.Log(pacerPos);
        
        if (pacerPos.x > Screen.width || pacerPos.x < 0)
        {
            direction *= -1;
        }
    }
}

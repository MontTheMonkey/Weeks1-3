using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circleMover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 crlPos = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        //These three input methods check if an input is being pressed and returns a boolean [true or false]
        bool rightKeyDown = Input.GetKeyDown(KeyCode.RightArrow);
        bool upKeyDown = Input.GetKeyDown(KeyCode.UpArrow);
        bool downKeyDown = Input.GetKeyDown(KeyCode.DownArrow);
        if (rightKeyDown == true)
        {
            crlPos.x = crlPos.x + 0.5f;
        }
        if (upKeyDown == true)
        {
            crlPos.y = crlPos.y + 0.1f;
        }
        if (downKeyDown == true)
        {
            crlPos.y = crlPos.y - 0.1f;
        }
        transform.position = crlPos;
    }
}

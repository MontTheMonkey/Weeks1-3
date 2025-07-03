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
        //GetKey checks if the key is being pressed
        //GetKeyDown checks once the key has been pressed down
        //GetKeyUp checks once the key has been released
        bool rightKey = Input.GetKey(KeyCode.RightArrow);
        bool upKeyDown = Input.GetKeyDown(KeyCode.UpArrow);
        bool downKeyUp = Input.GetKeyUp(KeyCode.DownArrow);
        if (rightKey == true)
        {
            crlPos.x = crlPos.x + 0.005f;
        }
        if (upKeyDown == true)
        {
            crlPos.y = crlPos.y + 0.1f;
        }
        if (downKeyUp == true)
        {
            crlPos.y = crlPos.y - 0.1f;
        }
        transform.position = crlPos;
    }
}

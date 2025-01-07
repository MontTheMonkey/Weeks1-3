using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//The silly doc: https://docs.unity3d.com/6000.0/Documentation/ScriptReference/Input-mousePosition.html 
public class circFollow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector2 mousePos = Input.mousePosition;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = mousePos;
    }
}

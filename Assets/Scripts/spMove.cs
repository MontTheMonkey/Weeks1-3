using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spMove : MonoBehaviour
{
    // Start is called before the first frame update
    [Range(0, 15)]
    public float mSpeed = 3.5f;
    public float mJump = 5f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Left screen
        Vector2 screenSizeZero = Camera.main.ScreenToWorldPoint(Vector2.zero);

        //Right screen
        Vector2 pos = transform.position;
        Vector2 upD = transform.up;
        Vector2 screenSize = new Vector2(Screen.width, Screen.height);
        Vector2 screenSizeWorld = Camera.main.ScreenToWorldPoint(screenSize);

        pos.x += mSpeed * Time.deltaTime;
        transform.position = pos;

        if (pos.x < screenSizeZero.x)
        {
            Vector2 zerodPos = new Vector2(screenSizeWorld.x, 0);
            pos.x = zerodPos.x;
            mSpeed = mSpeed * -1;
        }
        else if (pos.x > screenSizeWorld.x)
        {
            Vector2 zerodPos = new Vector2(screenSizeWorld.x, 0);
            pos.x = zerodPos.x;
            mSpeed = mSpeed * -1;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            upD.y = mJump;
        }

    }
}

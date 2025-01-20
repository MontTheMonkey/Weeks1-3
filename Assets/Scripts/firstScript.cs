using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class firstScript : MonoBehaviour
{
    public float speed = 3.5f;
    // Start is called before the first frame update
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
        Vector2 screenSize = new Vector2(Screen.width, Screen.height);
        Vector2 screenSizeWorld = Camera.main.ScreenToWorldPoint(screenSize);

        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        if (pos.x < screenSizeZero.x)
        {
            //pos.x = screenSizeZero.x; <Trial
            Vector2 zerodPos = new Vector2(screenSizeWorld.x, 0);
            pos.x = zerodPos.x;
            speed = speed * -1;
        }
        else if(pos.x > screenSizeWorld.x)
        {
            //pos.x = screenSizeWorld.x; <Trial
            Vector2 zerodPos = new Vector2(screenSizeWorld.x, 0);
            pos.x = zerodPos.x;
            speed = speed * -1;
        }
    }
}

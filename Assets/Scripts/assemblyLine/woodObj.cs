using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class woodObj : MonoBehaviour
{
    Vector3 woodPos;
    public GameObject woodObject;
    public Sprite plankSpr;
    public Sprite woodSpr;
    public SpriteRenderer woodRender;
    public float woodSpeed = 1.25f;
    Vector3 woodOrigin = new Vector3(-11, -1.51f, 0);
    bool startLine;
    // Start is called before the first frame update
    void Start()
    {
        woodPos = woodOrigin;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            startLine =! startLine;
        }
        if (startLine == true)
        {
            woodPos.x = woodPos.x + woodSpeed * Time.deltaTime;
        }
            
        if (woodPos.x > -0.5f)
        {
            woodRender.sprite = plankSpr;
        }
        if (woodPos.x > 11f)
        {
            woodPos = new Vector3(-11, -1.51f, 0);
            woodRender.sprite = woodSpr;
        }
        transform.position = woodPos;
        Debug.Log("The position of the wood is " + woodPos);
    }
}

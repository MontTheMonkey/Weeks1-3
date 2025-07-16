using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class woodObj : MonoBehaviour
{
    Vector3 woodPos;
    public GameObject woodObject;
    //"Plank" sprite is DOMO-KUN of the NHK property. Image of unknown origin though I found it in the README of this git repo 
    //Note: THIS IS NOT MY GIT REPO - https://github.com/peterfraedrich/domo-bot/blob/master/README.md. It has an identical image though.
    public Sprite plankSpr;
    //Log sprite is from Adobe Stock (AdobeStock_757803228)
    public Sprite woodSpr;
    public SpriteRenderer woodRender;
    public float woodSpeed = 1.25f;
    Vector3 woodOrigin = new Vector3(-11, -2.83f, 0);
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
            //This moves the wood along the conveyor belt
            woodPos.x = woodPos.x + woodSpeed * Time.deltaTime;
        }
            
        if (woodPos.x > -0.5f)
        {
            woodRender.sprite = plankSpr;
        }
        if (woodPos.x > 11f)
        {
            //Resets the wood to the start of the conveyor
            woodPos = woodOrigin;
            woodRender.sprite = woodSpr;
        }
        transform.position = woodPos;
        Debug.Log("The position of the wood is " + woodPos);
    }
}

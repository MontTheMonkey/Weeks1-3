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
    // Start is called before the first frame update
    void Start()
    {
        woodPos = new Vector3(-11, -1.51f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            woodPos.x = woodPos.x + 1.25f * Time.deltaTime;
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

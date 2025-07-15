using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class woodObj : MonoBehaviour
{
    Vector3 woodPos;
    public GameObject woodObject;
    public Sprite plankSpr;
    public SpriteRenderer woodSpr;
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
            woodSpr.sprite = plankSpr;
        }
        if (woodPos.x > 11.5f)
        {
            Destroy(woodObject);
        }
        transform.position = woodPos;
        Debug.Log("The position of the wood is " + woodPos);
    }
}

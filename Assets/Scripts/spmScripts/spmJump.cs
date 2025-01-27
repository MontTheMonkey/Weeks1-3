using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spmJump : MonoBehaviour
{
    //Class to change Mario's sprite
    public SpriteRenderer sprChange;
    //Jumping & base Mario sprite array
    public Sprite[] smSprites;

    //Mario's jump height
    [Range(0, 10)]
    public float mJump = 5f;
    // Start is called before the first frame update
    void Start()
    {
        //sprChange.sprite;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 upD = transform.up;
        //This if statement checks if you've pressed the spacebar, 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            upD.y = upD.y + mJump * Time.deltaTime;
            sprChange.sprite = smSprites[Random.Range(1,2)];
        }
    }
}

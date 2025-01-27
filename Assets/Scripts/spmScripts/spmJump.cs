using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class spmJump : MonoBehaviour
{
    //Class to change Mario's sprite
    public SpriteRenderer sprChange;
    //Jumping & base Mario sprite array
    public Sprite[] smSprites;
    //Animation curve for jump
    public AnimationCurve curve;


    //Mario's jump height lerp range 
    [Range(0, 1)]
    public float mJump = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Mario's jump is from -1.75 to 1 Y value
        Vector2 jNeu = new Vector2(0, -1.75f);
        Vector2 jFull = new Vector2(0, 1);

        //This if statement checks if you've pressed the spacebar, initiating the jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sprChange.sprite = smSprites[Random.Range(1, 3)];
            transform.position = Vector2.Lerp(jNeu, jFull, curve.Evaluate(mJump));
            mJump = mJump + 0.1f;
        }
        if (mJump == 1 || mJump == 0)
        {
            sprChange.sprite = smSprites[0];
        }
    }
}

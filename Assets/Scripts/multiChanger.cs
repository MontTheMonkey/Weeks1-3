using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class multiChanger : MonoBehaviour
{
    float timer;
    bool colChanged;
    bool sizeChanged;
    bool objRotated;
    Vector3 objRotation;
    public SpriteRenderer objSprite;
    public GameObject changedObj;
    // Start is called before the first frame update
    void Start()
    {
        objRotation.z = 180;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 3)
        {
            objSprite.color = Color.green;
            colChanged = true;
        }
        if (timer > 4 && colChanged == true && sizeChanged == false)
        {
            transform.localScale = transform.localScale * 2;
            sizeChanged = true;
        }
        if (timer > 5 && sizeChanged == true && objRotated == false)
        {
            transform.eulerAngles = objRotation;
            objRotated = true;
        }
        if (timer > 6 && objRotated == true)
        {
            Destroy(gameObject);
            timer = 0;
        }
    }
}

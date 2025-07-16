using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class rangeFinder : MonoBehaviour
{
    public SpriteRenderer rfSprite;
    float targetDis = 5f;
    float vDistance;
    Vector3 origin = new Vector3();
    Camera igCam;
    // Start is called before the first frame update
    void Start()
    {
        origin = transform.position;
        rfSprite = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        target.z = 0;
        vDistance = Vector3.Distance(target, origin);
        if (vDistance > targetDis)
        {
            rfSprite.color = Color.green;
        }
        else
        {
            rfSprite.color = Color.blue;
        }
    }
}

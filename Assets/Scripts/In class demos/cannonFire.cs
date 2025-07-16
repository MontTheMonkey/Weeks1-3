using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

public class cannonFire : MonoBehaviour
{
    Vector3 origin = new Vector3();
    Vector3 target = new Vector3();
    Vector2 cannonAim = new Vector3();
    public GameObject cnBallObj;
    public Color cannonBallColour;
    // Start is called before the first frame update
    void Start()
    {
        origin = transform.position;
        origin.z = 0f;
        transform.position = origin;
    }

    // Update is called once per frame
    void Update()
    {
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        cannonAim = origin - target;
        transform.right = -cannonAim;
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(cnBallObj);
        }
        //cannonBall cannonBall;
        //cannonBall.shotDuration;
    }
}

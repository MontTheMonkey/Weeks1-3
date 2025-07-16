using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonBall : MonoBehaviour
{
    Vector3 startPos = new Vector3();
    Vector3 endPos = new Vector3();
    public GameObject cnBallObj;
    public float shotDuration = 3f;
    float time = 0f;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        startPos.z = 2f;
        endPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        endPos.z = 2f;
        Destroy(cnBallObj, shotDuration);
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        Vector3 output = Vector3.Lerp(startPos, endPos, time / shotDuration);
        transform.position = output;
    }
}

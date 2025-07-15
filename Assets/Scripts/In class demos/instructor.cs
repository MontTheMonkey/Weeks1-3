using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instructor : MonoBehaviour
{
    public float start, end, time = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float output = Mathf.Lerp(start, end, time);
        Debug.Log("Lerp output is " + output);
    }
}

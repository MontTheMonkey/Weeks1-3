using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UI.Image;

public class knightChar : MonoBehaviour
{
    public GameObject fireballPrefab;
    Vector3 origin = new Vector3();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        origin = transform.position;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(fireballPrefab, origin, transform.rotation);
        }
    }
}

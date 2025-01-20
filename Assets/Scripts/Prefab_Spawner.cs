using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prefab_Spawner : MonoBehaviour
{
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector2 noZee = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(prefab, noZee, Quaternion.identity);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timedSpawner : MonoBehaviour
{
    float timer;
    float timeLastSpawned;
    public GameObject objPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > 3)
        {
            Instantiate(objPrefab);
            timer = 0;
        }
    }
}

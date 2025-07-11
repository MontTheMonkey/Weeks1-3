using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject objPrefab;
    public Vector3 spawnPoint;
    public List<GameObject> spawnedObjs = new List<GameObject>();
    List<int> destroyTimers = new List<int>();
    private float destroyTimer = 0.1f;
    int ed = -1;
    // Start is called before the first frame update
    void Start()
    {
        //GameObject silly = Instantiate(objPrefab, spawnPoint, Quaternion.identity);
        //spawnedObjs.Add(silly);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("The destroy timer is " + destroyTimer);
        Debug.Log("The destroy timer place is " + destroyTimers.Count);

        if (Input.GetKeyDown(KeyCode.Mouse0)) //&& spawnedObjs.Count < 10)
        {
            spawnedObjs.Add(Instantiate(objPrefab));
            destroyTimers.Add(Mathf.RoundToInt(destroyTimer * 10));
            destroyTimer += 0.1f;
            for (int i = 0; i < spawnedObjs.Count; i++)
            {
                Destroy(spawnedObjs[destroyTimers[i]], destroyTimer);
            }
         
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            for (int i = 0; i < spawnedObjs.Count; i++)
            {
                Destroy(spawnedObjs[i], 0.1f * i);
            }
            spawnedObjs.Clear();
            destroyTimers.Clear();
            destroyTimer = 0f;
        }

        if (spawnedObjs.Count == 0)
        {
            destroyTimers.Clear();
            destroyTimer = 0;
        }
    }
}

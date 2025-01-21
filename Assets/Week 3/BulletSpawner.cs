using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject prefab;
    public Bullet bullet;

    void Start()
    {
        Spawn();
    }

    void Update()
    {
        if(bullet.hasFired == true)
        {
            Spawn();
            bullet.hasFired = false;
        }

        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }

    void Spawn()
    {
        GameObject bulletGo = Instantiate(prefab);
        bullet = bulletGo.GetComponent<Bullet>();
        Destroy(bulletGo, 10);
    }

    void Fire()
    {
        bullet.hasFired = true;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SniperBullet : Bullet
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 15f);//same function as bullet
    }

    // Update is called once per frame
    void Update()
    {
        speed = 20f;
        transform.Translate(1 * speed * Time.deltaTime, 0, 0);//same as bullet but has the sniper's bullet speed instead
    }
}

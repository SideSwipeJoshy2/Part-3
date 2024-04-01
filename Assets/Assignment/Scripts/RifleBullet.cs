using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class RifleBullet : Bullet
{
    
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3f);//same as bullet, destroys earlier though
    }

    // Update is called once per frame
    void Update()
    {
      speed = 10f;
        transform.Translate(1 * speed * Time.deltaTime, 0, 0);//same as bullet, but has a different speed
    }
}

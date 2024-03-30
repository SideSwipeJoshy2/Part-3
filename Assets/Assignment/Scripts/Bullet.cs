using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    float speed =5f;
    // Start is called before the first frame update
    void Start()
    {
    Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(1 * speed * Time.deltaTime, 0, 0);
       

    }


}

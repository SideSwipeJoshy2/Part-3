using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

   public float speed =5f;
    Rigidbody rb;
    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        Destroy(gameObject, 5f);
    }


 
    // Update is called once per frame
    protected virtual void Update()
    {
        transform.Translate(1 * speed * Time.deltaTime, 0, 0);
       

    }



    
   
}

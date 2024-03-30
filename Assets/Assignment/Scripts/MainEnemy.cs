using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;

public class MainEnemy : MonoBehaviour
{
    Rigidbody2D rb;



    protected Vector2 destination;
    Vector2 movement;
    protected float speed = 3;
    static int ammomax = 10;
     public GameObject projectile;
    public Transform spawn;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        destination = transform.position;
    }
    


    private void FixedUpdate()
    {
        movement = destination - (Vector2)transform.position;

        //flip the x direction of the game object & children to face the direction we're walking
        if (movement.x > 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (movement.x < 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }

        //stop moving if we're close enough to the target
        if (movement.magnitude < 0.1)
        {
            movement = Vector2.zero;
            speed = 3;
        }
        rb.MovePosition(rb.position + movement.normalized * speed * Time.deltaTime);

    }



    protected virtual void Update()
    {
        //left click: move to the click location
        if (Input.GetMouseButtonDown(0))
        {
            destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        if (Input.GetKey(KeyCode.Space) && ammomax>0)
        {
            Instantiate(projectile, spawn.position, spawn.rotation);
            ammomax --;
        }
        if (Input.GetKey(KeyCode.R))
        {
            reload();
        }
    }

    public void reload()
    {
        if (ammomax == 0)
        {
               ammomax = 10; 
        }
    }






}

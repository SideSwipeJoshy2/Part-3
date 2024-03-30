using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;

public class MainEnemy : MonoBehaviour
{
    Rigidbody2D rb;



    protected float speed = 3;
    static int ammomax = 10;
     public GameObject projectile;
    public Transform spawn;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    protected virtual void Update()
    {
        
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

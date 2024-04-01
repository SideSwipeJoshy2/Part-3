using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class Pistol : MonoBehaviour
{

    protected int ammomax = 5;
    public GameObject projectile;
    public Transform spawn;
   protected bool reloading = false;
   protected bool canShoot = true;
   protected float reloadTimer = 2f;

    private void Start()
    {
        print("You have 5 shots in the pistol, 10 in the rifle, and 1 in the sniper");
    }


    protected virtual void Update()
    {

        if (Input.GetKeyDown(KeyCode.P) && ammomax> 0)
        {
 pistolshoot();
            

        }

        if (Input.GetKey(KeyCode.L) && !reloading)
        {
            StartCoroutine(Reload());
        }

        


    }

    public virtual void pistolshoot()
    {

        Instantiate(projectile, spawn.position, spawn.rotation);
        ammomax--;

    }

    public virtual IEnumerator Reload()
    {
        reloading = true;
        canShoot = false;

        yield return new WaitForSeconds(reloadTimer);
   
        if (ammomax == 0)
        {
            ammomax = 5;
          
            canShoot = true;
            reloading = false;
           
        }
        

    }

    
    

    

    }








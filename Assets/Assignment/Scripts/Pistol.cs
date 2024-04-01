using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class Pistol : MonoBehaviour
{
    //variables for checking the reload, magazine, and setting the spawnpoint of the bullet
    protected int ammomax = 5;//magazine variable
    public GameObject projectile;
    public Transform spawn;
   protected bool reloading = false;
   protected bool canShoot = true;
   protected float reloadTimer = 2f;

    private void Start()
    {//text to inform the user of magazine sizes
        print("You have 5 shots in the pistol, 10 in the rifle, and 1 in the sniper");
    }


    protected virtual void Update()
    {
//checks if p is pressed and if the ammo is greater than zero. if it is, fires a round
        if (Input.GetKeyDown(KeyCode.P) && ammomax> 0)
        {
 pistolshoot();
            

        }

        if (Input.GetKey(KeyCode.L) && !reloading)//checks if l is pressed and if the user is currently not reloading. if it is, reloads.
        {
            StartCoroutine(Reload());
        }

        


    }

    public virtual void pistolshoot() // this function shoots the pistol and removes a round from the magazine
    {

        Instantiate(projectile, spawn.position, spawn.rotation);
        ammomax--;

    }

    public virtual IEnumerator Reload() //coroutine that reloads the weapon on a timer. if the weapon is reloading it cannot fire until waitforseconds is finished.
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








using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class MainEnemy : MonoBehaviour
{

    protected int ammomax = 5;
    public GameObject projectile;
    public Transform spawn;
   protected bool reloading = false;
   protected bool canShoot = true;
   protected float reloadTimer = 2f;


   
    protected virtual void Update()
    {

        if (Input.GetKeyDown(KeyCode.P) && ammomax > 0)
        {
            Instantiate(projectile, transform.position, transform.rotation);
            ammomax--;

        }

        if (Input.GetKey(KeyCode.L) && !reloading)
        {
            StartCoroutine(Reload());
        }



    }

   public virtual IEnumerator Reload()
    {
        reloading = true;
        canShoot = false;

        yield return new WaitForSeconds(reloadTimer);
        //This causes the code to wait here for 3 seconds before continuing.
        if (ammomax == 0)
        {
            ammomax = 5;

            canShoot = true;
            reloading = false;
        }
    }

    

    

    }








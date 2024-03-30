using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;

public class MainEnemy : MonoBehaviour
{
    
   protected static int ammomax = 10;
     public GameObject projectile;
    public Transform spawn;

    protected float firerate = 1;

    
    protected virtual void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.F) && ammomax>0)
        {
            StartCoroutine(firerat());
        }
        if (Input.GetKey(KeyCode.R))
        {
            reload();
        }
    }

    IEnumerator firerat()
    {
        Instantiate(projectile, transform.position, transform.rotation);   
        yield return new WaitForSeconds(1/firerate/60);
        ammomax--;
    }

    public void reload()
    {
        if (ammomax == 0)
        {
               ammomax = 10; 
        }
    }






}

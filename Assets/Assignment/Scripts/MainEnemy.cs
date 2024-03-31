using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;

public class MainEnemy : MonoBehaviour
{
    
   protected int ammomax = 5;
     public GameObject projectile;
    public Transform spawn;

    protected float firerate = 1;

    
    protected virtual void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.P) && ammomax>0)
        {
            StartCoroutine(firerat());
        }
        if (Input.GetKey(KeyCode.R))
        {
            Reload();
        }
    }

    IEnumerator firerat()
    {
        Instantiate(projectile, transform.position, transform.rotation);   
        yield return new WaitForSeconds(1/firerate/60);
        ammomax--;
    }

    public virtual void Reload()
    {
        if (ammomax == 0)
        {
               ammomax = 5; 
        }
    }






}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Rifle : Pistol
{
    // variables for the size of the rifle magazine and a timer/fire rate variable for the automatic fire
   static float firerate = 0.25f;
    static float timer = 0.25f;
  static int rifleammomax = 10;
    
    // Start is called before the first frame update
    private void Start()
    {
        reloadTimer = 3f;//sets reload time
    }



    public override IEnumerator Reload()//functionally identical to the reload class
    {

        reloading = true;
        canShoot = false;

        yield return new WaitForSeconds(reloadTimer);

        if (rifleammomax== 0)//this has changed to allow for the reload of the rifle and its mag
        {
            rifleammomax= 10;
            
            canShoot = true;
            reloading = false;
        }
        firerate = 0.25f;//resets the firerate on the rifle to the pre overloaded state
        timer = 0.25f;
        print("Rifle Reloaded");//tells the user that the rifle is finished reloading
    }

    public static void Overload()//overloads the magazine of the rifle to 20 and tells the user that the rifle is in a different stat
    {
        rifleammomax = 20;
        print("Rifle Overloaded!");
        
    }


    private void Update()
    {

       if (Input.GetKey(KeyCode.R) && rifleammomax> 0)//same as pistol
        {
            if (Time.time - firerate > timer)//controls the fire rate of the rifle
            {
                firerate = Time.time;
                Instantiate(projectile, spawn.position, spawn.rotation);
                rifleammomax--;


            }
        }
        if (Input.GetKeyDown(KeyCode.D) && !reloading) //same as pistol
            {
                StartCoroutine(Reload());
            print("reloading rifle");
            }

        if (Input.GetKeyDown(KeyCode.O))//overload call, boosts fire rate massively
        {
            Overload();
            timer = 0.1f;
            firerate = 0.1f;
        }

        
    }
}
 
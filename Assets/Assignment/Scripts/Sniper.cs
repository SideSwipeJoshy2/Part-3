using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Sniper : Pistol
{
    // Start is called before the first frame update

    static int bolt = 1; //magazine for sniper

    private void Start()
    {
       
       
        reloadTimer = 5f;//change the reload time
    }

    

    public override IEnumerator Reload()//functionally identical to the pistol, just changed for the sniper
    {

        reloading = true;
        canShoot = false;

        yield return new WaitForSeconds(reloadTimer);

        if (bolt== 0)
        {
            bolt = 1;

            canShoot = true;
            reloading = false;
        }
        print("try pressing Z!");//hint for the user to use the "free shot" 
    }

    public void snipershoot()//shoots the sniper
    {
        if (Input.GetKeyDown(KeyCode.S) && bolt > 0)
        {
            Instantiate(projectile, transform.position, transform.rotation);
            bolt--;
            
        }
    }

   
  

    public override void pistolshoot()//free shot
    {
        base.pistolshoot();
        print("Free Shot!");
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S) && bolt > 0)//all pretty similar to the usual
        {
        snipershoot();
        }

        if (Input.GetKeyDown(KeyCode.X) && !reloading)
        {
            StartCoroutine(Reload());
            print("Reloading Sniper");
        
        }
        if(Input.GetKeyDown(KeyCode.Z)) {// free shot

            pistolshoot(); 
        }

    }


}

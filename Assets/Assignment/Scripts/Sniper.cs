using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Sniper : Pistol
{
    // Start is called before the first frame update

    int bolt = 1;
   

    private void Start()
    {
       
       
        reloadTimer = 5f;
    }

    

    public override IEnumerator Reload()
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
        print("try pressing O!");
    }

    public void snipershoot()
    {
        if (Input.GetKeyDown(KeyCode.S) && bolt > 0)
        {
            Instantiate(projectile, transform.position, transform.rotation);
            bolt--;
            
        }
    }

   
    public void Overload()
    {

        bolt = 3;
        print("3 Shots!");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S) && bolt > 0)
        {
        snipershoot();
        }

        if (Input.GetKeyDown(KeyCode.X) && !reloading)
        {
            StartCoroutine(Reload());
        
        }
        if(Input.GetKeyDown(KeyCode.O)) { 
            
           Overload(); 
        }

    }


}

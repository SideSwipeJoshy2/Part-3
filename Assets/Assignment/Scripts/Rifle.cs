using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Rifle : Pistol
{

   static float firerate = 0.25f;
    static float timer = 0.25f;
  static int rifleammomax = 10;
    
    // Start is called before the first frame update
    private void Start()
    {
        reloadTimer = 3f;
    }



    public override IEnumerator Reload()
    {

        reloading = true;
        canShoot = false;

        yield return new WaitForSeconds(reloadTimer);

        if (rifleammomax== 0)
        {
            rifleammomax= 10;

            canShoot = true;
            reloading = false;
        }

    }

    


    private void Update()
    {

       if (Input.GetKey(KeyCode.R) && rifleammomax> 0)
        {
            if (Time.time - firerate > timer)
            {
                firerate = Time.time;
                Instantiate(projectile, spawn.position, spawn.rotation);
                rifleammomax--;


            }
        }
        if (Input.GetKeyDown(KeyCode.D) && !reloading)
            {
                StartCoroutine(Reload());
            }

        
    }
}
 
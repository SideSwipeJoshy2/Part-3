using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Rifle : MainEnemy
{

   static float firerate = 0.25f;
    static float timer = 0.25f;

    // Start is called before the first frame update
    private void Start()
    {
        ammomax = 10;
        reloadTimer = 3f;
    }



    public override IEnumerator Reload()
    {

        reloading = true;
        canShoot = false;

        yield return new WaitForSeconds(reloadTimer);

        if (ammomax == 0)
        {
            ammomax = 10;

            canShoot = true;
            reloading = false;
        }

    }



    private void Update()
    {
        if (Input.GetKey(KeyCode.R) && ammomax > 0)
        {
            if (Time.time - firerate > timer)
            {
                firerate = Time.time;
                Instantiate(projectile, transform.position, transform.rotation);
                ammomax--;


            }
        }
            if (Input.GetKeyDown(KeyCode.D) && !reloading)
            {
                StartCoroutine(Reload());
            }

        
    }
}
 
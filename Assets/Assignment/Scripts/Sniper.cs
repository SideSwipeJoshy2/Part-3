using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Sniper : MainEnemy
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

    }



    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S) && bolt > 0)
        {
            Instantiate(projectile, transform.position, transform.rotation);
            bolt--;


        }

        if (Input.GetKeyDown(KeyCode.X) && !reloading)
        {
            StartCoroutine(Reload());
        }

    }


}

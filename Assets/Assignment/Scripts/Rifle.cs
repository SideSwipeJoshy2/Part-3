using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : MainEnemy
{


    // Start is called before the first frame update
    private void Start()
    {
        ammomax = 10;
    }


    IEnumerator fireratrifle()
    {
        
            Instantiate(projectile, transform.position, transform.rotation);
            yield return new WaitForSeconds(1 / firerate / 60);
            ammomax--;
      
    }

    public override void Reload()
    {
        base.Reload();
        ammomax = 10;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S) && ammomax > 0)
        {
            StartCoroutine(fireratrifle());
            

        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Reload();
        }

    }


    }
 
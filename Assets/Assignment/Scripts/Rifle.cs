using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : MainEnemy
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    IEnumerator firerat()
    {
        Instantiate(projectile, transform.position, transform.rotation);
        yield return new WaitForSeconds(1 / firerate / 60);
        ammomax--;
    }

    
}

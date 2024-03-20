using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Thief : Villager
{
    public GameObject knifePrefab;
    public Transform spawnPoint1;
    public Transform spawnPoint2;
    public float dashSpeed;
    //float timer;
    //public float dashTime = 3;
    //bool isDash;
    Coroutine dashing;
    protected override void Attack()
    {
        if(dashing != null)
        {
            StopCoroutine(dashing);
        }
        dashing = StartCoroutine(Dash());

            
    }
    public override ChestType CanOpen()
    {
        return ChestType.Thief;
    }

   IEnumerator  Dash()
    {
        destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        speed = 7;
        while (speed > 3)
        {
            yield return null;
        }

        base.Attack();
        yield return new WaitForSeconds(0.1f);
            Instantiate(knifePrefab, spawnPoint1.position, spawnPoint1.rotation);
        yield return new WaitForSeconds(0.1f);

            Instantiate(knifePrefab, spawnPoint2.position, spawnPoint2.rotation);

       
    }

    public override string ToString()
    {
        return "hi bob";
    }
}

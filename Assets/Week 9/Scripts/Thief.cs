using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thief : Villager
{
    public GameObject daggerPrefab;
    public Transform spawnPoint;
    public Transform spawnPoint2;

    public override ChestType canOpen()
    {
        return ChestType.Thief;
    }

    protected override void Attack()
    {
        base.Attack();
        Instantiate(daggerPrefab, spawnPoint.position, spawnPoint.rotation);
        Instantiate(daggerPrefab, spawnPoint2.position, spawnPoint2.rotation);

        
            base.speed = 10;
            destination = spawnPoint2.position;
            destination = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        

    }


}

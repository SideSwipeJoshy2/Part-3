using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WepCheck : MonoBehaviour
{
    TextMeshPro tmp;

    private void Start()
    {
       tmp = GetComponent<TextMeshPro>();
    }

    private void Update()
    {
        tmp.text = "sniper";
        
    }

}
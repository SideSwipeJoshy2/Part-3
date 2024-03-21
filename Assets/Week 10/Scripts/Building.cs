using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour
{
    // Start is called before the first frame update
    float interpolation;
    float start;
    float end;

    GameObject gameObject1;
    GameObject gameObject2;
    GameObject gameObject3;

    void Start()
    {
        StartCoroutine(build());
    }

    
    IEnumerator build()
    {
        gameObject1.transform.localScale = Vector3.Lerp(Vector3.one, Vector3.zero, interpolation);
        yield return new WaitForSeconds(0.3f);
        
    }


}
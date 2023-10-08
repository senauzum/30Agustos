using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destory : MonoBehaviour
{
    public string parentName;
    void Start()
    {
        parentName = transform.name;
       
    }
    IEnumerator DestoryClone()
    {
        yield return new WaitForSeconds(10);
        if (parentName == "Section(Clone)")
        {
            Destroy(gameObject);
        }
    }
}

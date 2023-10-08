using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectFlag : MonoBehaviour
{
    public AudioSource flagFx;
    private void OnTriggerEnter(Collider other)
    {
        flagFx.Play();
        CollectableControl.coinCount += 1;
        this.gameObject.SetActive(false);
    }
   
}

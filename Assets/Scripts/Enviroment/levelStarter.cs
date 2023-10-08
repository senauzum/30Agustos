using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelStarter : MonoBehaviour
{
    public GameObject countDown3;
    public GameObject countDown2;
    public GameObject countDown1;
    public GameObject countDownBaþla;
    public GameObject fadeIn;
    public AudioSource goFX;

    void Start()
    {
        StartCoroutine(CountSequence());
    }

   IEnumerator CountSequence()
    {
        yield return new WaitForSeconds(1.5f);
        countDown3.SetActive(true);
        goFX.Play();
        yield return new WaitForSeconds(1);
        countDown2.SetActive(true);
        goFX.Play();
        yield return new WaitForSeconds(1);
        countDown1.SetActive(true);
        goFX.Play();
        yield return new WaitForSeconds(1);
        countDownBaþla.SetActive(true);
        goFX.Play();
        playermove.canMove = true;

    }
}

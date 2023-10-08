using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaclecollection : MonoBehaviour
{
    public GameObject thePlayer;
    public GameObject charModel;
    public AudioSource crashThuld;
    public GameObject mainCam;
    public GameObject LevelControl;
  
    private void OnTriggerEnter(Collider other)
    {
        this.gameObject.GetComponent<BoxCollider>().enabled = false;
        thePlayer.GetComponent<playermove>().enabled = false;
        charModel.GetComponent<Animator>().Play("Stumble Backwards");
        LevelControl.GetComponent<LevelDistance>().enabled = false;
        crashThuld.Play();
        mainCam.GetComponent<Animator>().enabled = true;
        LevelControl.GetComponent<EndRunSequence>().enabled = true;
    }
  
    }

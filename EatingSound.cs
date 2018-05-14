using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatingSound : MonoBehaviour {

    public AudioClip MusicClip;

    public AudioSource MusicSource;
	// Use this for initialization
	void Start ()
    {
        MusicSource.clip = MusicClip;	
	}
	
	// Update is called once per frame
	void Update ()
    {
        if ((HealthPick.foodCanGet != 0) && (Input.GetButtonDown("RB_Button")))
        {
            MusicSource.Play();
        }
    }
}

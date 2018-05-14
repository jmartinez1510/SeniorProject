using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StompWhiff : MonoBehaviour
{

    public AudioClip MusicClip;

    public AudioSource MusicSource;
    // Use this for initialization
    void Start()
    {
        MusicSource.clip = MusicClip;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            MusicSource.Play();
        }
        if (Input.GetButtonDown("A_Button"))
        {
            MusicSource.Play();
        }
    }
}

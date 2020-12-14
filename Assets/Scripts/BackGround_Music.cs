/***
Name:Elijah Tong
Student Number: 101126281
Source File: BackGround_Music.cs
Last Modified: 2020-12-12
Description: This script will play the background music when the script is run and loop it when the track ends.
***/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround_Music : MonoBehaviour
{
    AudioSource BackGroundMusic;
    // Start is called before the first frame update
    void Start()
    {
        BackGroundMusic = GetComponent<AudioSource>();
        BackGroundMusic.Play();
        BackGroundMusic.loop = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

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

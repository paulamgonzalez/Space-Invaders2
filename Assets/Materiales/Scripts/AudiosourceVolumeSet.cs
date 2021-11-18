using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class AudiosourceVolumeSet : MonoBehaviour
{
    public string keyValue = "sliderEffect";
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Awake()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        audioSource.volume = PlayerPrefs.GetFloat(keyValue, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

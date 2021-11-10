using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioControler : MonoBehaviour
{
    public Slider sliderMusic;
    public Slider sliderEffect;
    public AudioSource musicFondo;
    public AudioSource musicBottons;
    // Start is called before the first frame update
    void Start()
    {
        musicFondo.volume = sliderMusic.value;
        musicBottons.volume = sliderEffect.value;

    }
    
    public void SliderSoundModified()
    {
        musicFondo.volume = sliderMusic.value;
    }

    public void SliderEffectModified()
    {
        musicBottons.volume = sliderEffect.value;
    }
}

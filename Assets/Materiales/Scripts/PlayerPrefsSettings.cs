using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPrefsSettings : MonoBehaviour
{
    public Slider sliderMusic;
    public Slider sliderEffect;

    void OnEnable()
    {
        sliderMusic.value = PlayerPrefs.GetFloat("musicVolume", 1.0f);
        sliderEffect.value = PlayerPrefs.GetFloat("sfxVolume", 1.0f);
    }

    public void Cancelar()
    {
        sliderMusic.value = PlayerPrefs.GetFloat("musicVolume", 1.0f);
        sliderEffect.value = PlayerPrefs.GetFloat("sfxVolume", 1.0f);
    }


    public void Guardar()
    {
        PlayerPrefs.SetFloat("musicVolume", sliderMusic.value);
        PlayerPrefs.SetFloat("sfxVolume", sliderEffect.value);
        PlayerPrefs.Save();
    }

}

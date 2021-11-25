using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class ChangeMusic : MonoBehaviour, ISelectHandler
{
    public AudioSource musicaBoton;
    public AudioSource musicaAnterior;
    public AudioSource musicaAnterior2;
    public AudioSource musicaAnterior3;
    public Button myButton;

    // Update is called once per frame
   
        public void OnSelect(BaseEventData evenData)
        {
            musicaBoton.Play();
            musicaAnterior.Pause();
            musicaAnterior2.Pause();
            musicaAnterior3.Pause();
        }
  }

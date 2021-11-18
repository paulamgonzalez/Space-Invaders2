using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class ChangeIdioma : MonoBehaviour
{
    int index = 0;
    
    public void NextLenguage()
    {
        index++; 
        if(index > 1)
        {
            index = 0;
        }
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[index];
    }

    public void PreviousLenguage()
    {
        index--;
        if (index < 0)
        {
            index = 1;
        }
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[index];
    }
}


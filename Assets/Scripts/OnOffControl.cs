using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnOffControl : MonoBehaviour
{
    AudioSource sesKontrol;

    void Start()
    {
        //ses
        sesKontrol = GetComponent<AudioSource>();
        if (PlayerPrefs.GetInt("sesDurum")==1)
        {
            sesKontrol.mute = false;
        }
        else
        {
            sesKontrol.mute = true;
        }
    }
}

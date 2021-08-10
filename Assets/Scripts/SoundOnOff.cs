using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOnOff : MonoBehaviour
{
    public GameObject sesAcik, sesKapali;

    void Update()
    {
        //ses
        if (PlayerPrefs.GetInt("sesDurum")==1)
        {
            sesAcik.SetActive(true);
            sesKapali.SetActive(false);
        }
        else
        {
            sesAcik.SetActive(false);
            sesKapali.SetActive(true); 
        }
    }


    //ses
    public void sesDurum(string durum)
    {
        if (durum=="acik")
        {
            sesAcik.SetActive(false);
            sesKapali.SetActive(true);
            PlayerPrefs.SetInt("sesDurum", 0);
        }
        else if (durum=="kapali")
        {
            sesAcik.SetActive(true);
            sesKapali.SetActive(false);
            PlayerPrefs.SetInt("sesDurum", 1);
        }
    }
}

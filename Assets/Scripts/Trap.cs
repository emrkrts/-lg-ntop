using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{  
    void OnTriggerEnter2D(Collider2D collider)
    {        
        HeartControl.instance.hp--;
        HeartControl.instance.heartShow();
        if (HeartControl.instance.hp >= 1)
        {
            SoundControl.PlaySound("damage");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        HeartControl.instance.hp--;
        HeartControl.instance.heartShow();
        if (HeartControl.instance.hp >= 1)
        {
            SoundControl.PlaySound("damage");
        }
    }
}
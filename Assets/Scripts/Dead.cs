using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        HeartControl.instance.hp-= HeartControl.instance.maxhp;
        HeartControl.instance.heartShow();
        if (HeartControl.instance.hp <= 0)
        {
            SoundControl.PlaySound("death");
        } 
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{    void OnTriggerEnter2D(Collider2D collider)
    {
        HeartControl.instance.hp++;
        HeartControl.instance.heartShow();
    }
}

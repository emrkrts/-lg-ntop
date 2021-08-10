using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControl : MonoBehaviour
{
    public static AudioClip damageSound, jumpSound, winSound, deathSound;
    static AudioSource audioSrc;

    void Start()
    {
        damageSound = Resources.Load<AudioClip>("damage");
        jumpSound = Resources.Load<AudioClip>("jump");
        winSound = Resources.Load<AudioClip>("win");
        deathSound = Resources.Load<AudioClip>("death");

        audioSrc = GetComponent<AudioSource>();
    }
    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "damage":
                audioSrc.PlayOneShot (damageSound);
                break;
            case "win":
                audioSrc.PlayOneShot (winSound);
                break;
            case "jump":
                audioSrc.PlayOneShot (jumpSound);
                break;
            case "death":
                audioSrc.PlayOneShot (deathSound);
                break;
        }
    }
}

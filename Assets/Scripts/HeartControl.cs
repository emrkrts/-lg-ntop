using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartControl : MonoBehaviour
{
    public GameObject [] heart;
    public int hp, maxhp, x=1;
    public GameObject gameOver, gameWin;


    public static HeartControl instance;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {     
        maxhp = 3;
        hp = 3;
        gameOver.gameObject.SetActive(false);
        gameWin.gameObject.SetActive(false);
    }

    void Update()
    {
        if (hp > maxhp)
        {
            hp = maxhp;
        }
        else if (hp <= 0)
        {
            gameOver.gameObject.SetActive(true);
            Time.timeScale = 0;
            if (x==1)
            {
                SoundControl.PlaySound("death");
                x++;
            }
        }        
    }

    public void heartShow()
    {
        for (int i = 0; i < maxhp; i++)
        {
            heart[i].gameObject.SetActive(false);
        }

        for (int i = 0; i < hp; i++)
        {
            heart[i].gameObject.SetActive(true);
        }
    }
}

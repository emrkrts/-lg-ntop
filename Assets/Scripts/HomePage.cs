﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomePage : MonoBehaviour
{
    public void sahnedegis()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }
}

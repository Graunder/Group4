﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public void PauseToQuit() {
        Application.Quit();
    }

    public void RetryLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void PauseToMenu() {
        SceneManager.LoadScene("Main_Menu");
    }
}

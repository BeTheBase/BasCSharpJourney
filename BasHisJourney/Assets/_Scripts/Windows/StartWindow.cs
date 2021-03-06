﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartWindow : GenericWindow
{

    public Button ContinueButton;

    public override void Open()
    {
        var canContinue = true;

        ContinueButton.gameObject.SetActive(canContinue);

        if (ContinueButton.gameObject.active)
        {
            FirstSelected = ContinueButton.gameObject;
        }


        base.Open();
    }

    public void NewGame()
    {
        SceneManager.LoadScene(1);
        Debug.Log("New Game Pressed");
    }

    public void Continue()
    {
        Debug.Log("Continue Pressed");
    }

    public void Options()
    {
        Manager.Open(1);
        Debug.Log("Options Pressed");
    }

    public void HighScore()
    {
        Manager.Open(2);
        Debug.Log("HighScore Pressed");
    }

    public void Quit()
    {
        Application.Quit();
    }


}

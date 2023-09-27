using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            ChangeScene("MainMenu");
    }

    public void ChangeScene(string SceneTarget)
    {
        SceneManager.LoadScene(SceneTarget);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

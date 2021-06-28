using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartBtn() {
        SceneManager.LoadScene("3DFlying");
    }

    public void ToggleOptionsMenu() {
        //turns on options-gameobject
    }

    public void QuitGame() {
        Application.Quit();
    }
}

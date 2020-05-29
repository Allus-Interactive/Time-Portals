using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Build Index:
    // 0 - Menu
    // 1 - World Map
    // 2 - Relics Collection
    // 3 - Profile
    // 4 - Basic Portal
    
    public void Awake()
    {
        // Ask for camera permissions if not already given
        if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
        {
            Permission.RequestUserPermission(Permission.Camera);
        }
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void GoToGame()
    {
        SceneManager.LoadScene(1);
    }

    public void GoToRelics()
    {
        SceneManager.LoadScene(2);
    }

    public void GoToProfile()
    {
        SceneManager.LoadScene(3);
    }

    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}

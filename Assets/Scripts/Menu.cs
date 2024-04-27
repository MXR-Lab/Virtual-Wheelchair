using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void LoadTestWalk()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void LoadTestChair()
    {
        SceneManager.LoadSceneAsync(2);
    }
    public void LoadLinWalk()
    {
        SceneManager.LoadSceneAsync(3);
    }
    public void LoadCurvWalk()
    {
        SceneManager.LoadSceneAsync(4);
    }
    public void LoadLinChair()
    {
        SceneManager.LoadSceneAsync(5);
    }
    public void LoadCurvChair()
    {
        SceneManager.LoadSceneAsync(6);
    }
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
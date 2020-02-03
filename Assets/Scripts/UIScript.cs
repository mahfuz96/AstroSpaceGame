using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene(1);
    }
    
    public void Restart()
    {
        SceneManager.LoadScene(1);
    }
    public void Tutorial()
    {
        SceneManager.LoadScene(3);
    }
    public void Back()
    {
        SceneManager.LoadScene(0);
    }
    public void Options()
    {
        SceneManager.LoadScene(4);
    }
    public void Quit()
    {
        Application.Quit();
    }
}

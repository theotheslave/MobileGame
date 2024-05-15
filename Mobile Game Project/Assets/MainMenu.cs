using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1); 
        
        /* 1 is basically the next scene in line
        you can find the order of the scenes under 'file' and 'build settings' */
        
    }
}

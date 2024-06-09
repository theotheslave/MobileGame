using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript1 : MonoBehaviour
{
    public void ReturnGame()
    {
        SceneManager.LoadScene("StartArea");
    }
}


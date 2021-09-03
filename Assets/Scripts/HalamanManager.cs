using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HalamanManager : MonoBehaviour
{
    public bool isEscapeToExit;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (isEscapeToExit)
            {
                Application.Quit();
            }
            else
            {
                KembalikeMenu();
            }
        }
    }

    public void MulaiPermainan()
    {
        SceneManager.LoadScene("Main");
    }

    public void KembalikeMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}

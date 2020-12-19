using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour
{

    void Start()
    {
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void GoToPlay()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Main", LoadSceneMode.Single);
      
    }
 
}

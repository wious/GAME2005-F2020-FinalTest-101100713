using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour
{
    public void GoToPlay()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Main", LoadSceneMode.Single);
      
    }
 
}

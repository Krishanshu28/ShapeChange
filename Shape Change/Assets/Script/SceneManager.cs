using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneManage : MonoBehaviour
{
    public void OnStartclick()
    {
        SceneManager.LoadScene(1);
        
    }
    public void OnQuitButton()
    {
        Application.Quit();
    }
}

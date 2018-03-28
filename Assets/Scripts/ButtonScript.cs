using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{



    public void scenechanger(int sceneNum)
    {
        SceneManager.LoadScene(sceneNum);
    }



    public void Kill()
    {
        Application.Quit();
    }
}

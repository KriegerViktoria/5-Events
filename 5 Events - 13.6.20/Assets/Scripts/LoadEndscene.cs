using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadEndscene : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene(sceneName: "End");


    }
}


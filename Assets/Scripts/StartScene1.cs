using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene1 : MonoBehaviour
{
    public float startTimer = 1.0f;

    void Start()
    {
        Invoke("StartScene", startTimer);        
    }

    void StartScene()
    {
        SceneManager.LoadScene(1);
    }

}

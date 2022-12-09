using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameRestart : MonoBehaviour
{
    // script that restarts the scene

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewGameRestart()
    {
        // game can be restarted
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        // Debug.Log("scene is restarted");
    }


}







using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLvl : MonoBehaviour
{
    public GameManager gameManager;
    string curScene;

    public void loadNextScene()
    {
        curScene = SceneManager.GetActiveScene().name;
        if (curScene == "lvl01")
        {
            SceneManager.LoadScene(2);
        }
        if (curScene == "lvl02")
        {
            SceneManager.LoadScene(3);
        }
        
    }
    private void FixedUpdate()
    {
        if (Input.GetKey("space"))
        {
            loadNextScene();
        }
    }
}

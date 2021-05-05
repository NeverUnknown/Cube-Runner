using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 5f;
    public GameObject completeLevelUI;
    public GameObject mainMenuUI;
    public GameObject ExitMenuUI;
    public GameObject instructionUI;

    public void EndGame()
    {
        if (!gameHasEnded)
        {
            //Debug.Log("YOU DIED");
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
    }

    /*void loadScene()
    {
        SceneManager.LoadScene("lvl02");
    }*/

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        FindObjectOfType<PlayerMovement>().forwardForce = 0f;
        FindObjectOfType<PlayerMovement>().sidewaysForce = 0f;
        FindObjectOfType<PlayerMovement>().rigidbody.velocity = new Vector3(0, 0, 0);

        /*if (SceneManager.GetActiveScene().name == "lvl01")
        {
            Invoke("loadScene", 5f);
        }*/
        if (SceneManager.GetActiveScene().name == "lvl02")
        {
            Invoke("ExitMenu", 5f);
        }
    }

    void ExitMenu()
    {
        SceneManager.LoadScene("Exit");
    }

    void Restart()
    {
        //SceneManager.LoadScene("lvl01");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);// загружает текущую сцену
    }

    public void StartButton()
    {
        mainMenuUI.SetActive(false);
        instructionUI.SetActive(true);
        //SkipInfo();
    }

    public void SkipInfo()
    {
        instructionUI.SetActive(false);
        SceneManager.LoadScene("lvl01");
    }


    public void QuitGame()
    {
        Application.Quit();
    }

}

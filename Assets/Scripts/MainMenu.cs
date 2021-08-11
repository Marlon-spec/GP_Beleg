using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame() // if assigned button is clicked Load the next Scene in the Buld Index
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    
    public void QuitGame()  // if assigned button is clicked quit/close the Game
    {
        Debug.Log("Quit");
        Application.Quit();
    }

}

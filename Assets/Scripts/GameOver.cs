using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void RestartGame()       // if assigned button is clicked load new Scene 
    {
        SceneManager.LoadScene("First Level");
    }
    public void BackToMenu()            // if assigned button is clicked load new Scene 
    {
        SceneManager.LoadScene("MainMenu");
    }
}

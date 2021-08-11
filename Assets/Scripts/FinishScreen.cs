using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishScreen : MonoBehaviour
{
   public void PlayGame()              // if assigned button is clicked load new Scene 
    {
        SceneManager.LoadScene("First Level");
    }

    public void BackToMenu()           // if assigned button is clicked load new Scene 
    {
        SceneManager.LoadScene("MainMenu");
    }
}

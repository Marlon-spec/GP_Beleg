using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;   


public class Death : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)  // if player touches one of those 2D Colliders he will die 
    {
        if(collision.gameObject.tag == "Player")  
        {
            SceneManager.LoadScene("Game Over"); // Load the Game Over Scene for the Player

        }
    }

}

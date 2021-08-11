using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;   


public class Death : MonoBehaviour
{
     private CharacterController characterController;

    void Start()
    {
        characterController = GameObject.Find("Player").GetComponent<CharacterController>();
    }

    private void OnTriggerEnter2D(Collider2D collision)  
    {
        if(collision.gameObject.tag == "Player")  
        {
            PlayerPrefs.SetInt("coins", characterController.coins);
            PlayerPrefs.SetFloat("time", characterController.secondsLeft);

            SceneManager.LoadScene("Game Over"); 

        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Finish : MonoBehaviour
{
    [SerializeField] private string sceneName;

    private void OnTriggerEnter2D(Collider2D collision)  //if collison with game Object tagged Player load new Scene called Finish
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Finish");

        }
    }

}


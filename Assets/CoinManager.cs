using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI coins;
    [SerializeField] private TextMeshProUGUI time;

    // Start is called before the first frame update
    void Start()
    {
        coins.text = PlayerPrefs.GetInt("coins").ToString();
        time.text = PlayerPrefs.GetFloat("time").ToString().Substring(0,5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ValueManager : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI[] coinText;
    [SerializeField] public TextMeshProUGUI[] timeText;

    PlayerData data = new PlayerData();

    void Start()
    {
        Debug.Log(SaveSystem.Instance);
        data = SaveSystem.Instance.LoadPlayer();
        foreach (var text in coinText)
        {
            text.text = "-";
        }
        foreach (var text in timeText)
        {
            text.text = "-";
        }
        for (int i = 0; i < data.coinList.Count; i++)
        {
            coinText[i].text = data.coinList[i].ToString();
            timeText[i].text = data.secondsLeftList[i].ToString();
        }
    }
}

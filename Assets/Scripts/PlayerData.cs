using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class PlayerData {

    public List<int> coinList;
    public List<float> secondsLeftList;

    public PlayerData()
    {
        coinList = new List<int>();
        secondsLeftList = new List<float>();
    }
    public void StoreData(int coins, float secondsLeft)
    {
        if (coinList == null || secondsLeftList == null)
        {
            coinList = new List<int>();
            secondsLeftList = new List<float>();
        }
        if (coinList.Count < 11 ) 
        {
            coinList.Add(coins);
            secondsLeftList.Add(secondsLeft);
        }
        else if(coins > coinList[10])
        {
            coinList.RemoveAt(10);
            secondsLeftList.RemoveAt(10);
            coinList.Add(coins);
            secondsLeftList.Add(secondsLeft);
        }
        else if (coins == coinList[10])
        {
            if (secondsLeft > secondsLeftList[10])
            {
                coinList.RemoveAt(10);
                secondsLeftList.RemoveAt(10);
                coinList.Add(coins);
                secondsLeftList.Add(secondsLeft);
            }

        }

        BubbleSort();

    }

    private void BubbleSort()
    {
     if (coinList.Count > 1)
        {
            for (int i = coinList.Count - 2; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (coinList[i] <= coinList[i +1])
                    {
                        if(secondsLeftList[i] < secondsLeftList[i+1])
                        {
                            var number = coinList[i];
                            coinList[i] = coinList[i + 1];
                            coinList[i + 1] = number;

                            var time = secondsLeftList[i];
                            secondsLeftList[i] = secondsLeftList[i + 1];
                            secondsLeftList[i + 1] = time;
                        }
                    }
                }
            }
                
        }
        
    }



}

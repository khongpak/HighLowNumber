using System.Collections.Generic;
using UnityEngine;

public class RandomNumber 
{
    public static RandomNumber Instance;

    public List<int> numberBox = new List<int>();

    void Awake()
    {
        Instance = this;
    }

    public void PrepareNumber()
    {
        numberBox.Clear();

        for (int i = 0; i<=10; i++)
        {
            numberBox.Add(i);
        }

        for(int i = 0; i < numberBox.Count; i++)
        {
            int temp = numberBox[i];
            int randomIndex = Random.Range(i, numberBox.Count);
            numberBox[i] = numberBox[randomIndex];
            numberBox[randomIndex] = temp;
        }
    }


    // public void PickUpNumber()
    // {
    //     if(numberBox.Count > 0)
    //     {
    //         int PickUpNumber = numberBox[0];
    //         numberBox.Remove(0);
    //     }
    // }

}

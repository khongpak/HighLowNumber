using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI lastNumberText;
    public TextMeshProUGUI currentNumberText;

    public int lastNumber;
    public int currentNumber;

    RandomNumber RdNumber = new RandomNumber();

    public List<int> numberRandom = new List<int>();

    public void Start()
    {
        RdNumber.PrepareNumber();
        numberRandom = RdNumber.numberBox;
        Debug.Log("Number Count "+ numberRandom.Count);
        PickUpNumber();       

        Debug.Log("Number Count "+ numberRandom.Count);
        PickUpNumber();  

        Debug.Log("Number Count "+ RdNumber.numberBox.Count);
        

    }

    public void PickUpNumber()
    {
        if(numberRandom.Count > 0)
        {
            int PickUpNumber = numberRandom[0];
            numberRandom.RemoveAt(0);
        }
    }
}

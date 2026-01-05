using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI lastNumberText;
    public TextMeshProUGUI currentNumberText;

    private int numberIndex = 0;

    RandomNumber RdNumber = new RandomNumber();

    public List<int> numberRandom = new List<int>();

    public void Start()
    {
        RdNumber.PrepareNumber();
        numberRandom = RdNumber.numberBox;      

    }

    public void CheckNumber(int ButtonClick)
    {
        if(ButtonClick == 0)
        {
            Debug.Log($"Previous Number : {numberRandom[numberIndex]} , Current Number : {numberRandom[numberIndex+1]} ");
            if(numberRandom[numberIndex] > numberRandom[numberIndex+1])
            {
                Debug.Log("Correct");
                lastNumberText.text = numberRandom[numberIndex].ToString();
                currentNumberText.text = numberRandom[numberIndex+1].ToString();
                numberIndex++;
            }
            else
            {
                Debug.Log("Wrong");
                lastNumberText.text = numberRandom[numberIndex].ToString();
                currentNumberText.text = numberRandom[numberIndex+1].ToString();
                numberIndex++;
            }
        }

        if(ButtonClick == 1)
        {
            Debug.Log($"Previous Number : {numberRandom[numberIndex]} , Current Number : {numberRandom[numberIndex+1]} ");
            if(numberRandom[numberIndex] < numberRandom[numberIndex+1])
            {
                Debug.Log("Correct");
                lastNumberText.text = numberRandom[numberIndex].ToString();
                currentNumberText.text = numberRandom[numberIndex+1].ToString();
                numberIndex++;
            }
            else
            {
                Debug.Log("Wrong");
                lastNumberText.text = numberRandom[numberIndex].ToString();
                currentNumberText.text = numberRandom[numberIndex+1].ToString();
                numberIndex++;
            }
            
        }
    }


}

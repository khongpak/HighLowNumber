using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI lastNumberText;
    public TextMeshProUGUI currentNumberText;
    public TextMeshProUGUI slotNumber;

    private int numberIndex = 0;
    private List<int> listNumber = new List<int>();

    RandomNumber RdNumber = new RandomNumber();

    public List<int> numberRandom = new List<int>();

    public void Start()
    {
        RdNumber.PrepareNumber();
        numberRandom = RdNumber.numberBox;
        lastNumberText.text = numberRandom[0].ToString();
        listNumber.Add(numberRandom[0]);
        slotNumber.text = listNumber[0].ToString();      

    }

    public void CheckNumber(int ButtonClick)
    {
        if(numberIndex != numberRandom.Count-1){

            if(ButtonClick == 0)
            {
                
                if(numberRandom[numberIndex] > numberRandom[numberIndex+1])
                {
                    Debug.Log("Correct");
                    NextNumber();
                }
                else
                {
                    Debug.Log("Wrong");
                    NextNumber();
                }
            }

            if(ButtonClick == 1)
            {
                
                if(numberRandom[numberIndex] < numberRandom[numberIndex+1])
                {
                    Debug.Log("Correct");
                    NextNumber();
                }
                else
                {
                    Debug.Log("Wrong");
                    NextNumber();
                }
                
            }

            listNumber.Add(numberRandom[numberIndex]);
            slotNumber.text = slotNumber.text + " --> " + listNumber[numberIndex].ToString();
        }
        else
        {
            lastNumberText.text = "End Game";
        }
    }

    private void NextNumber()
    {
        lastNumberText.text = numberRandom[numberIndex].ToString();
        currentNumberText.text = numberRandom[numberIndex+1].ToString();
        numberIndex++;
    }


}

using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI lastNumberText;
    public TextMeshProUGUI currentNumberText;
    public TextMeshProUGUI slotNumberText;
    public TextMeshProUGUI healthText;

    public int startNumber;
    public int endNumber;
    public int health = 3;

    private int numberIndex = 0;
    private List<int> listNumber = new List<int>();

    RandomNumber RdNumber = new RandomNumber();

    public List<int> numberRandom = new List<int>();

    public void Start()
    {
        RdNumber.PrepareNumber(startNumber,endNumber);
        numberRandom = RdNumber.numberBox;
        lastNumberText.text = numberRandom[0].ToString();
        listNumber.Add(numberRandom[0]);
        slotNumberText.text = listNumber[0].ToString();

        healthText.text = health.ToString();      

    }

    public void CheckNumber(int ButtonClick)
    {
        if(numberIndex != numberRandom.Count-1 && health > 0){

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
                    health--;
                    healthText.text = health.ToString();
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
                    health--;
                    healthText.text = health.ToString();
                }
                
            }

            listNumber.Add(numberRandom[numberIndex]);
            slotNumberText.text = slotNumberText.text + " --> " + listNumber[numberIndex].ToString();
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

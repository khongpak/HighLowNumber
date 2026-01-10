using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public AudioManager audioManager;

    public TextMeshProUGUI lastNumberText;
    public TextMeshProUGUI currentNumberText;
    public TextMeshProUGUI slotNumberText;

    public Button highButton;
    public Button lowButton;
    public Button restartButton;
    public Button nextButton;

    public int startNumber;
    public int endNumber;

    private int numberIndex = 0;
    private List<int> listNumber = new List<int>();

    RandomNumber RdNumber = new RandomNumber();

    public List<int> numberRandom = new List<int>();
    public List<Image> heart = new List<Image>();

    void Awake()
    {
        restartButton.gameObject.SetActive(false);
        nextButton.gameObject.SetActive(false);
    }

    public void Start()
    {
        RdNumber.PrepareNumber(startNumber,endNumber);
        numberRandom = RdNumber.numberBox;
        lastNumberText.text = numberRandom[0].ToString();
        listNumber.Add(numberRandom[0]);
        slotNumberText.text = listNumber[0].ToString();

        audioManager.PlayBGMAudio();
  

    }

    void Update()
    {
        CheckWin();    
    }

    public void CheckNumber(int ButtonClick)
    {
        if(numberIndex != numberRandom.Count-1 && heart.Count > 0){

            if(ButtonClick == 0)
            {
                if(numberRandom[numberIndex] > numberRandom[numberIndex+1])
                {
                    Debug.Log("Correct");
                    audioManager.PlayCorrectAnswer();
                    NextNumber();
                }
                else
                {
                    Debug.Log("Wrong");
                    audioManager.PlayWrongAnswer();
                    NextNumber();
                    heart[0].gameObject.SetActive(false);
                    heart.RemoveAt(0);
                }
            }

            if(ButtonClick == 1)
            {
                if(numberRandom[numberIndex] < numberRandom[numberIndex+1])
                {
                    Debug.Log("Correct");
                    audioManager.PlayCorrectAnswer();
                    NextNumber();
                }
                else
                {
                    Debug.Log("Wrong");
                    audioManager.PlayWrongAnswer();
                    NextNumber();
                    heart[0].gameObject.SetActive(false);
                    heart.RemoveAt(0);
                    
                }
                
            }

            listNumber.Add(numberRandom[numberIndex]);
            slotNumberText.text = slotNumberText.text + " " + listNumber[numberIndex].ToString();
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

    private void CheckWin()
    {
        if(numberIndex >= numberRandom.Count-1 && heart.Count > 0)
        {
            Debug.Log("You Win!");
            highButton.gameObject.SetActive(false);
            lowButton.gameObject.SetActive(false);
            lastNumberText.text = "You Win";
            nextButton.gameObject.SetActive(true);
        }

        if(numberIndex < numberRandom.Count-1 && heart.Count <= 0)
        {
            Debug.Log("You Lost");
            highButton.gameObject.SetActive(false);
            lowButton.gameObject.SetActive(false);
            lastNumberText.text = "Game Over";
            restartButton.gameObject.SetActive(true);
        }

        
    }

}

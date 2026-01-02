using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI lastNumberText;
    public TextMeshProUGUI currentNumberText;

    public int lastNumber;
    public int currentNumber;

    public void Start()
    {
        
        lastNumberText.text = lastNumber.ToString();
    }

    public void Update()
    {
        lastNumber = Random.Range(1, 10);
        Debug.Log(lastNumber);
    }
}

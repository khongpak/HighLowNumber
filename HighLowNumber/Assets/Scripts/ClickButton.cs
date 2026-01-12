using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickButton : MonoBehaviour
{
    public string nextSceneName;

    public void NextScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Start()
    {
        AudioManager.instance.PlayBGM(0);
    }

    void Update()
    {

    }
    public void StartNewGame()
    {

        SceneManager.LoadScene("Loading");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}

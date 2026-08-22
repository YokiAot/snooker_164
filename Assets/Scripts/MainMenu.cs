using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Start()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Scence01");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Start()
    {
        AudioMenager.Instance.PlayBGM(0);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Scene01");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
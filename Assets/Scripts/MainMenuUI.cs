using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("CharacterCreator");
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Game closed");
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
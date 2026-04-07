using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    public void StartProject()
    {
        SceneManager.LoadScene("CharacterCreator");
    }

    public void ExitProject()
    {
        Application.Quit();
        Debug.Log("Project closed.");
    }
}
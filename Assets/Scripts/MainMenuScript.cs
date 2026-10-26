using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("MiniGame"); 
    }

    public void QuitGame()
    {
        Debug.Log("Quit");      
        Application.Quit();     
    }
}

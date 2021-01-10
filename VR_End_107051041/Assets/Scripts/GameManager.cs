using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("期末");
    }

    public void QuitGame()
    {
        Application.Quit(); //離開遊戲
    }
}

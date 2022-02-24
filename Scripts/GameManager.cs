using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    bool GameHasEnded = false;
    public GameObject winScreen;

    public void WinGame()
    {
        winScreen.SetActive(true);
    }
    public void EndGame()
    {
        if (GameHasEnded == false)
        {
            GameHasEnded = true;
            Debug.Log("GameOver");
            Restart();
        }

    }
    void Restart()
    {
        SceneManager.LoadScene("SampleScene");
    }
}

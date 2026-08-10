using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Logic : MonoBehaviour
{
    public int PlayerScore;
    public TextMeshProUGUI Score;
    public GameOverUI GameOverScreen;
    public float animationDuration = 0.4f;
    [ContextMenu("Increase Score")]
    public void AddScore(int ScoreToAdd)
    {
        PlayerScore += ScoreToAdd;
        Score.text = PlayerScore.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }

    public void GameOver()
    {
        GameOverScreen.Show();
        Time.timeScale = 0f;
    }
}

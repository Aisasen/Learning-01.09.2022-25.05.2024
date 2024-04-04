using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Player.Maxlives = PlayerPrefs.GetInt("MaxLives");
        Player.Currentlives = PlayerPrefs.GetInt("CurrentLives");
        Player.score = PlayerPrefs.GetInt("Score");
    }
}
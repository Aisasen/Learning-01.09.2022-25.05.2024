using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            PlayerPrefs.SetInt("MaxLives", Player.Maxlives);
            PlayerPrefs.SetInt("CurrentLives", Player.Currentlives);
            PlayerPrefs.SetInt("Score", Player.score);
            PlayerPrefs.Save();
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Player.Maxlives = PlayerPrefs.GetInt("MaxLives");
            Player.Currentlives = PlayerPrefs.GetInt("CurrentLives");
            Player.score = PlayerPrefs.GetInt("Score");
        }  
    }
}

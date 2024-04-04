using UnityEngine;
using UnityEngine.UI;

public class GameComplete : MonoBehaviour
{
    public GameObject GameCompleteWindow;
    public Text TotalScore;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Time.timeScale = 0f;
            GameCompleteWindow.SetActive(true);
            TotalScore.text = Player.score.ToString();
        }
    }
}

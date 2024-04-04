using UnityEngine;

public class Trader : MonoBehaviour
{
    public GameObject tradeWindow;
    public GameObject Ekey;
    private bool canTrade;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            canTrade = true;
            Ekey.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            canTrade = false;
            tradeWindow.SetActive(false);
            Ekey.SetActive(false);
        }
    }

    private void Update()
    {
        if (canTrade && Input.GetKeyDown(KeyCode.E))
        {
            if (tradeWindow.activeSelf)
            {
                tradeWindow.SetActive(false);
            }
            else
                tradeWindow.SetActive(true);
        }
    }
}


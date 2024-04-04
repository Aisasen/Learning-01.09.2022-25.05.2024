using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaxHealth : MonoBehaviour
{
    private RectTransform MaximumHealth;
    void Start()
    {
        MaximumHealth = GetComponent<RectTransform>();
    }
    void Update()
    {
        MaximumHealth.localScale = new Vector2(Player.Maxlives * 0.01f, 0.3317f);
    }
}

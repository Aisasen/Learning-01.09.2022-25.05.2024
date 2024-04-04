using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentHealth : MonoBehaviour
{
    private RectTransform CurHealth;

    void Start()
    {
        CurHealth = GetComponent<RectTransform>();
    }

    void Update()
    {
        CurHealth.localScale = new Vector2(Player.Currentlives*0.01f, 0.3317f);
    }
}

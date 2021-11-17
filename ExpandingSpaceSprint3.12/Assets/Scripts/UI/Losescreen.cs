using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Losescreen : MonoBehaviour
{
    [SerializeField] public GameObject loseWindow;
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "KillFloor")
        {
            loseWindow.SetActive(true);
        }
    }
}
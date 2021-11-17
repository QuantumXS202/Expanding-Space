using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallKill : MonoBehaviour
{
    [SerializeField] Transform spawnPoint;
    [SerializeField] public GameObject loseWindow;


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.transform.CompareTag("Player"))
        {
            col.transform.position = spawnPoint.position;
        }
    }
}
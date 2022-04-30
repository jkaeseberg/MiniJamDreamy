using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ledges : MonoBehaviour
{
    [SerializeField] GameObject EndScreenUI;

    private void Start()
    {
        EndScreenUI.SetActive(false);
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            EndScreenUI.SetActive(true);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndNightmare : MonoBehaviour
{
    [SerializeField] GameObject endScreen;


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            endScreen.SetActive(true);
        }
    }



}

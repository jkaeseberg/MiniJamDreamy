using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    [SerializeField] float speed = 20f;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] GameObject EscUI;
  
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
        }
        if (Input.GetKeyDown("a"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-speed,0);
        }

        if (Input.GetKeyDown("d"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
        }
        if (Input.GetKeyDown("escape"))
        {
            EscUI.SetActive(true);
        }
    }

}

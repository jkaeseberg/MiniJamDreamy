using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    [SerializeField] float speed = 20f;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] GameObject EscUI;
    [SerializeField] float dashSpeed;
    private bool canDash = true;

    private void Start()
    {
        EscUI.SetActive(false);
        DontDestroyOnLoad(gameObject);
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            rb.velocity = new Vector2(0, speed);
        }
        if (Input.GetKeyDown("a"))
        {
            rb.velocity = new Vector2(-speed,0);
        }

        if (Input.GetKeyDown("d"))
        {
            rb.velocity = new Vector2(speed, 0);
        }

        if (Input.GetKeyDown("escape"))
        {
            EscUI.SetActive(true);
        }

        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey("a") && canDash == true) 
        {
            rb.velocity = new Vector2(-dashSpeed, 0);
            canDash = false;
            StartCoroutine(Cooldown());
            
        }

        if(Input.GetKey(KeyCode.LeftShift) && Input.GetKey("d") && canDash == true)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(dashSpeed, 0);
            canDash = false;
            StartCoroutine(Cooldown());
           
        }


     
    }

    IEnumerator Cooldown()
    {
        yield return new WaitForSeconds(5f);
        canDash = true;
    }

}

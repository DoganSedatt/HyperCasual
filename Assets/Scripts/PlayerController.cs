using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    private float speed = 500f;
    CurrentDirection yonSecimi;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        yonSecimi = CurrentDirection.left;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            ChangeDirection();
            StopPlayer();
        }
        
    }

    private enum CurrentDirection
    {
        right,
        left
    }

    private void ChangeDirection()
    {
        MovePlayer();
        if (yonSecimi == CurrentDirection.right)
        {//Eðer sað yön seçiliyse yön deðiþikliði metodu çalýþýnca onu sola çevir.
            yonSecimi = CurrentDirection.left;
        }
        else if (yonSecimi == CurrentDirection.left)
        {
            yonSecimi = CurrentDirection.right;
        }
    }

    private void MovePlayer()
    {
        if (yonSecimi == CurrentDirection.right)
        {
            rb.AddForce((Vector3.forward).normalized*speed*Time.deltaTime,ForceMode.VelocityChange);
        }
        else if (yonSecimi == CurrentDirection.left)
        {
            rb.AddForce((Vector3.right).normalized * speed * Time.deltaTime, ForceMode.VelocityChange);
        }
    }
    private void StopPlayer()
    {
        rb.velocity = Vector3.zero;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    private float speed = 5f;
    CurrentDirection yonSecimi;
    public bool isPlayerDead;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        yonSecimi = CurrentDirection.left;
        isPlayerDead = false;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (!isPlayerDead)
        {
            
            RayCastDetector();
            if (Input.GetKeyDown("space"))
            {
                ChangeDirection();
                StopPlayer();
            }
        }
        else
        {
            return;
        }
        
    }
    private void RayCastDetector()
    {
        RaycastHit zeminKontrol;
        if(Physics.Raycast(transform.position,Vector3.down,out zeminKontrol))
        {//Eðer player objem zemine temas ediyorsa hareket metodunu çaðýr
            MovePlayer();
        }
        else
        {
            //Player objem zemine temas etmiyorsa durdur
            StopPlayer();
            isPlayerDead = true;
            this.gameObject.SetActive(false);
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
            transform.Translate(Vector3.forward.normalized*speed*Time.deltaTime);
            //rb.AddForce((Vector3.forward).normalized*speed*Time.deltaTime,ForceMode.VelocityChange);
        }
        else if (yonSecimi == CurrentDirection.left)
        {
            transform.Translate(Vector3.right.normalized * speed * Time.deltaTime);
            //rb.AddForce((Vector3.right).normalized * speed * Time.deltaTime, ForceMode.VelocityChange);
        }
    }
    private void StopPlayer()
    {
        rb.velocity = Vector3.zero;
    }
}

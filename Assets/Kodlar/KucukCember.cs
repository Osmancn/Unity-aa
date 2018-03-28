using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KucukCember : MonoBehaviour {

    Rigidbody2D fizik;
    public float hiz;
    bool haraketKontrol = true;
    GameObject OyunYoneticisi;

    void Start()
    {
        fizik = GetComponent<Rigidbody2D>();
        OyunYoneticisi = GameObject.FindGameObjectWithTag("OyunYoneticisi");

    }

    void Update()
    {
        if(OyunYoneticisi.GetComponent<OyunYoneticisi>().oyunBittimi==true
            && Input.GetButtonDown("Fire1"))
        {
            SceneManager.LoadScene("AnaMenu")
        }
    }

    void FixedUpdate()
    {
        if (haraketKontrol)
        {
            fizik.MovePosition(fizik.position + Vector2.up * hiz * Time.deltaTime);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "BuyukCember")
        {
            haraketKontrol = false;
            transform.SetParent(collision.transform);
        }
        if(collision.tag=="KucukCember")
        {
            OyunYoneticisi.GetComponent<OyunYoneticisi>().OyunBitti();           
        }
    }
   
}

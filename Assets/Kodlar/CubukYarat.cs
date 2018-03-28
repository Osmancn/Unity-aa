using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CubukYarat : MonoBehaviour {

    public GameObject kucukCember;
    GameObject OyunYoneticisi;
    public Text KalanCubuk;
    public int AtilmasıGerekenCubuk;
    int kalanCubuk;

    void Start()
    {
        KalanCubuk.text = ""+AtilmasıGerekenCubuk;
        kalanCubuk = AtilmasıGerekenCubuk;
        OyunYoneticisi = GameObject.FindGameObjectWithTag("OyunYoneticisi");

    }

    void Update ()
    {
		if(kalanCubuk!=0 && Input.GetButtonDown("Fire1"))
        {
            CubukOlustur();
        }
        if(kalanCubuk==0 && 
            OyunYoneticisi.GetComponent<OyunYoneticisi>().oyunBittimi==false)
        {
            StartCoroutine(LevelAtlat());
        }
	}
    IEnumerator LevelAtlat()
    {

        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(int.Parse(SceneManager.GetActiveScene().name) + 1);
    }
    
    void CubukOlustur()
    {
        if(kalanCubuk!=0)
        {
            Instantiate(kucukCember, transform.position, transform.rotation);
            kalanCubuk--;
            KalanCubuk.text = ""+kalanCubuk;
        }       
    }
}

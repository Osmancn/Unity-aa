using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class OyunYoneticisi : MonoBehaviour {

    GameObject BuyukCember;
    GameObject AnaCember;
    public Animator Animator;
    public bool oyunBittimi = false;
    public Text Level;
    
    
    
    void Start()
    {
        BuyukCember = GameObject.FindGameObjectWithTag("BuyukCember");
        AnaCember = GameObject.FindGameObjectWithTag("AnaCember");
        Level.text = SceneManager.GetActiveScene().name;
    }



    public void OyunBitti()
    {
        StartCoroutine(IEOyunBitti());
    }
    IEnumerator IEOyunBitti()
    {
        BuyukCember.GetComponent<CemberDonme>().enabled = false;
        AnaCember.GetComponent<CubukYarat>().enabled = false;
        Animator.SetTrigger("OyunBitti");
        yield return new WaitForSeconds(0.5f);
        oyunBittimi = true;
    }
    
}

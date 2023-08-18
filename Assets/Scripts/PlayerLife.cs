using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rb;
    
    [SerializeField] AudioSource deathSound;
    
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        anim=GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            Die();
        }
    }
    
    private void Die()
    {
        deathSound.Play();
        rb.bodyType = RigidbodyType2D.Static;
        ItemCollector.SetCherriesCollected(CherryScore.cherriesCollected);
        anim.SetTrigger("death");
    }

    private void ResartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

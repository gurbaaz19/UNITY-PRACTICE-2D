using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEditor;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private AudioSource finishSound;
    // Start is called before the first frame update
    private void Start()
    {
        finishSound=GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            finishSound.Play();
            FinishLevel();
        }
    }
    
    private void FinishLevel()
    {
        CherryScore.cherriesCollected = ItemCollector.GetCherriesCollected();
        Debug.Log("Level Finished with " + CherryScore.cherriesCollected + " cherries collected.");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

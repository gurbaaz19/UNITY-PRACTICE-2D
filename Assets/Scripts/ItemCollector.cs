using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using DefaultNamespace;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ItemCollector : MonoBehaviour
{
    private int isBoxCollectedTime;
    private static int cherriesCollected=CherryScore.cherriesCollected;
    [SerializeField] private AudioSource collectSound;

    [SerializeField] private TextMeshProUGUI cherriesCollectedText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherry"))
        {
            collectSound.Play();
            Destroy(collision.gameObject);
            cherriesCollected++;
            cherriesCollectedText.text = $"Cherries Collected: {cherriesCollected.ToString()}";
        }

        if (collision.gameObject.CompareTag("Rock Box"))
        {
            collectSound.Play();
            Destroy(collision.gameObject);
            cherriesCollectedText.text =
                $"Cherries Collected: {cherriesCollected.ToString()}\nYou Collected a Message Box, you are doing great! Here are 20 cherry points for you.";
            cherriesCollected += 20;
            isBoxCollectedTime = 500;
        }
    }

    private void Update()
    {
        if (isBoxCollectedTime!=0)
        {
            isBoxCollectedTime--;
            Debug.Log(isBoxCollectedTime);
            if (isBoxCollectedTime == 0)
            {
                cherriesCollectedText.text = $"Cherries Collected: {cherriesCollected.ToString()}";
            }
        }
    }
    
    public static int GetCherriesCollected()
    {
        return cherriesCollected;
    }
    
    public static void SetCherriesCollected(int cherriesCollected)
    {
        ItemCollector.cherriesCollected = cherriesCollected;
    }
}
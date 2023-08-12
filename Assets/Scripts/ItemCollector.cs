using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
public class ItemCollector : MonoBehaviour
{
    private int cherriesCollected;
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
    }
}
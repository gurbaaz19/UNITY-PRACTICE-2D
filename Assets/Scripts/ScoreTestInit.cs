using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using TMPro;
using UnityEngine;

public class ScoreTestInit : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI cherriesCollectedText;
    // Start is called before the first frame update
    void Start()
    {
        cherriesCollectedText.text = $"Cherries Collected: {CherryScore.cherriesCollected.ToString()}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using TMPro;
using UnityEngine;

public class FinalScoreDisplay : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI finalScoreText;
    // Start is called before the first frame update
    void Start()
    {
        finalScoreText.text = $"Game Over \n Final Score: {CherryScore.cherriesCollected.ToString()}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using TMPro;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    [SerializeField] private float score = 0;
    [SerializeField] private TextMeshProUGUI scoreText;
    
    public void IncrementScore()
    {
        score++;
        scoreText.text = $"Score: {score}";
    }
}



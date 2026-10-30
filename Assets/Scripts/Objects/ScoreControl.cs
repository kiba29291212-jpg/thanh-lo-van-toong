using UnityEngine;
using TMPro;

public class ScoreControl : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;

    public static float totalScore = 0f;

    private void Start()
    {
        UpdateScoreUI();
    }

    public void UpdateScoreUI()
    {
        scoreText.text = "Score : " + totalScore;
    }
}
using UnityEngine;
using TMPro;

public class ScoreControl : MonoBehaviour
{
    [SerializeField] private GameObject scoreBox;

    public static float totalScore = 0f;

    private TMP_Text scoreText;

    private void Awake()
    {
        scoreText = scoreBox.GetComponent<TMP_Text>();
    }

    private void Update()
    {
        scoreText.text = "Score : " + totalScore;
    }
}
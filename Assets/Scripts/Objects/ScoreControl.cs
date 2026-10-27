using UnityEngine;

public class ScoreControl : MonoBehaviour
{
    [SerializeField] GameObject scoreBox;
    public static float totalScore = 0f;

    void Update()
    {
        scoreBox.GetComponent<TMPro.TMP_Text>().text = "Score : " + totalScore;
    }
}
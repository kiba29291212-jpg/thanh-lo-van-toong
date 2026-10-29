using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class WinLoseManager : MonoBehaviour
{

    private void Update()
    {
        WinLoseScene();
    }


    private void WinLoseScene()
    {
        if (ScoreControl.totalScore >= 100)
        {
            SceneManager.LoadScene("WIN");
            ScoreControl.totalScore = 0;
        }
        
        if(Player.playerCurrentHealth <= 0)
        {
            SceneManager.LoadScene("LOSE");
            ScoreControl.totalScore = 0;
        }
    }
}

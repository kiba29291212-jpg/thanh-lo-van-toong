using System;
using Unity.VectorGraphics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinSceneButton: MonoBehaviour
{
    [SerializeField] private Button restartButton;
    [SerializeField] private Button menuButton;

    private void Start()
    {
        restartButton.onClick.AddListener(OnRestartClicked);

        menuButton.onClick.AddListener(OnMenuClicked);
    }

    private void OnRestartClicked()
    {
        SceneManager.LoadScene("SampleScene");
    }

    private void OnMenuClicked()
    {
        SceneManager.LoadScene("MainMenu");
    }

}

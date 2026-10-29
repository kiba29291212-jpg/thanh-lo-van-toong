using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuSystem : MonoBehaviour
{
    [SerializeField] private Button playButton;

    [SerializeField] private Button menuButton;

    [SerializeField] private Button vaoGameButton;

    [SerializeField] private GameObject nameInputPanel;

    [SerializeField] private TMP_InputField nameInputField;

    private void Start()
    {
        playButton.onClick.AddListener(OnPlayClicked);

        menuButton.onClick.AddListener(OnMenuClicked);

        vaoGameButton.onClick.AddListener(OnVaoGameClicked);
    }

    private void OnPlayClicked()
    {
        nameInputPanel.SetActive(true);
    }

    private void OnMenuClicked()
    {
        nameInputPanel.SetActive(false);
    }

    private void OnVaoGameClicked()
    {
        SceneManager.LoadScene("SampleScene");
    }
}

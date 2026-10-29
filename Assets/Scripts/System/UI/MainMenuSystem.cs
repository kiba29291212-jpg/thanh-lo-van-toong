using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEditor.PackageManager.UI;
using System.Linq;

public class MainMenuSystem : MonoBehaviour
{
    [SerializeField] private Button playButton;

    [SerializeField] private Button menuButton;

    [SerializeField] private Button vaoGameButton;

    [SerializeField] private GameObject nameInputPanel;

    [SerializeField] private TMP_InputField nameInputField;

    [SerializeField] private TMP_Text thongBao;

    [Header("MSV")]
    [SerializeField] private List<string> D26MaSinhVien = new List<string>();

    private void Start()
    {
        nameInputPanel.SetActive(false);

        playButton.onClick.AddListener(OnPlayClicked);

        menuButton.onClick.AddListener(OnMenuClicked);

        vaoGameButton.onClick.AddListener(OnVaoGameClicked);
    }

    private void OnPlayClicked()
    {
        nameInputPanel.SetActive(true);

        nameInputField.text = "";

        nameInputField.ActivateInputField();

        thongBao.text = "";   
    }

    private void OnMenuClicked()
    {
        nameInputPanel.SetActive(false);
    }

    private void OnVaoGameClicked()
    {

        string NhapMaSinhVien = nameInputField.text.Trim();

        if (string.IsNullOrEmpty(NhapMaSinhVien))
        {
            ShowStatus("VUI LÒNG NHẬP MÃ SINH VIÊN");
            return;
        }

        bool isValid = false;

        foreach (string code in D26MaSinhVien)
        {
            if (!string.IsNullOrWhiteSpace(code) && string.Equals(NhapMaSinhVien, code.Trim(), System.StringComparison.OrdinalIgnoreCase))
            {
                isValid = true;
                break;
            }
        }

        if (!isValid)
        {
            ShowStatus("MÃ SINH VIÊN KHÔNG HỢP LỆ");
            nameInputField.Select();
            nameInputField.ActivateInputField();
            return;
        }

        SceneManager.LoadScene("SampleScene");

        D26PassGCC.D26MSV = NhapMaSinhVien;
    }

    private void ShowStatus(string message)
    {
        thongBao.text = message;
    }
}
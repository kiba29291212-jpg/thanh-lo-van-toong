using System;
using Unity.VisualScripting;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine;
using System.Runtime.Serialization;

public class GemControl : MonoBehaviour
{
    [SerializeField] private float rotateSpeed = 2f;
    [SerializeField] private float gemScore = 10;
    [SerializeField] private GameObject gemObject;

    private void Update()
    {
        transform.Rotate(0, rotateSpeed, 0, Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        ScoreControl.totalScore += gemScore;

        ScoreControl scoreControl = FindFirstObjectByType<ScoreControl>();

        if (scoreControl != null)
        {
            scoreControl.UpdateScoreUI();
        }

        Destroy(gameObject);
    }
}

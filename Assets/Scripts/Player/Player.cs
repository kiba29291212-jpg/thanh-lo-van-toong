using UnityEngine;
using Unity.Mathematics;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [Header("Player Health")]
    [SerializeField] public float playerHealth = 100f;
    
    public static float playerCurrentHealth;

    private void Start()
    {
        playerCurrentHealth = playerHealth;
    }

    public void TakeDamage(float damage)
    {
        playerCurrentHealth -= damage;
        playerCurrentHealth = Mathf.Max(playerCurrentHealth, 0f);
    }
}

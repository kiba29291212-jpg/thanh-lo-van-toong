using UnityEngine;
using Unity.Mathematics;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [Header("Player Health")]
    [SerializeField] public float playerHealth = 100f;
    
    private float currentHealth;

    private void Start()
    {
        currentHealth = playerHealth;
    }

    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        currentHealth = Mathf.Max(currentHealth, 0f);

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    { 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

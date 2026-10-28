using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    [Header("Combat Setting")]
    [SerializeField] private float playerDamage = 20f;
    [SerializeField] private float attackCooldown = 1f;

    [Header("Attack Hitbox")]
    [SerializeField] private BoxCollider attackHitbox;
    [SerializeField] private LayerMask enemyLayer;

    [Header("Animation")]
    [SerializeField] private Animator animator;

    private InputSystem_Actions inputActions;
    private bool isAttacking;
    private float nextAttackTime;

    private readonly HashSet<EnemyAI> damagedEnemies = new HashSet<EnemyAI>();

    private void Awake()
    {
        inputActions = new InputSystem_Actions();

        if (animator == null)
        {
            animator = GetComponentInChildren<Animator>();
        }

        if (attackHitbox == null)
        {
            Transform hitboxTransform = transform.Find("AttackHitbox");

            if (hitboxTransform != null)
            {
                attackHitbox = hitboxTransform.GetComponent<BoxCollider>();
            }
        }
    }

    private void OnEnable()
    {
        inputActions.Player.Enable();
    }

    private void OnDisable()
    {
        inputActions?.Player.Disable();
    }

    private void OnDestroy()
    {
        inputActions?.Dispose();
    }

    private void Update()
    {
        if (inputActions == null || animator == null)
        {
            return;
        }

        Attack();
    }

    private void Attack()
    {
        if (inputActions.Player.Attack.IsPressed() && !isAttacking && Time.time >= nextAttackTime)
        {
            isAttacking = true;
            nextAttackTime = Time.time + attackCooldown;

            damagedEnemies.Clear();
            animator.SetTrigger("Attack");
        }
    }

    public void PlayerDealDamage()
    {
        if (!isAttacking || attackHitbox == null)
        {
            return;
        }

        Bounds bounds = attackHitbox.bounds;

        Collider[] hits = Physics.OverlapBox(bounds.center, bounds.extents, attackHitbox.transform.rotation, enemyLayer, QueryTriggerInteraction.Collide);

        foreach (Collider hit in hits)
        {
            EnemyAI enemyHealth = hit.GetComponentInParent<EnemyAI>();

            if (enemyHealth == null || damagedEnemies.Contains(enemyHealth))
            {
                continue;
            }

            damagedEnemies.Add(enemyHealth);
            enemyHealth.EnemyTakeDamage(playerDamage);
        }
    }

    public void FinishAttack()
    {
        isAttacking = false;
    }
}
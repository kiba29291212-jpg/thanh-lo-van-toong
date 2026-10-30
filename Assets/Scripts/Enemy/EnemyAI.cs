using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    [Header("Enemy Setting")]
    [SerializeField] public float enemyHealth = 100f;
    private float enemyCurrentHeath;
    private float originalSpeed;

    [Header("References")]
    [SerializeField] private Transform player;
    [SerializeField] private NavMeshAgent agent;

    [Header("Detection")]
    [SerializeField] private float detectionRange = 15f;
    [SerializeField] private float attackRange = 2f;
    [SerializeField] private Transform eyePoint;
    [SerializeField] private LayerMask visionMask = ~0;

    [Header("Combat")]
    [SerializeField] private float attackDamage = 10f;
    private bool isAttack;
    private bool isAttacking;

    [Header("Lost Player")]
    [SerializeField] private float lostPlayerWaitTime = 5f;
    [SerializeField] private float returnSpeed = 1f;
    private float lostPlayerTimer;
    private bool isReturning;
    private bool isWaiting;
    private bool hasDetectedPlayer;

    [Header("Animation")]
    [SerializeField] private Animator animator;

    private Vector3 startPosition;

    private void Start()
    {
        if (agent == null)
        {
            agent = GetComponent<NavMeshAgent>();
        }

        startPosition = transform.position;
        enemyCurrentHeath = enemyHealth;
        originalSpeed = agent.speed;
    }

    private void Update()
    {
        if (player == null || agent == null)
        {
            return;
        }

        if (isAttacking)
        {
            LookAtPlayer();
            HandleAnimation(true);
            return;
        }

        float distance = Vector3.Distance(transform.position, player.position);

        bool canSeePlayer = distance <= detectionRange && CanSeePlayer();

        if (canSeePlayer)
        {
            hasDetectedPlayer = true;
            isWaiting = false;
            isReturning = false;
            lostPlayerTimer = 0f;

            if (distance <= attackRange)
            {
                Attack();
            }
            else
            {
                ChasePlayer();
            }
        }
        else if (isReturning)
        {
            ReturnToStart();
        }
        else if (isWaiting)
        {
            agent.isStopped = true;

            lostPlayerTimer += Time.deltaTime;

            if (lostPlayerTimer >= lostPlayerWaitTime)
            {
                isWaiting = false;

                if (hasDetectedPlayer)
                {
                    isReturning = true;
                }
            }
        }
        else if (hasDetectedPlayer)
        {
            isWaiting = true;
            lostPlayerTimer = 0f;

            agent.isStopped = true;
            agent.ResetPath();
        }
        else
        {
            agent.isStopped = true;
        }

        HandleAnimation(canSeePlayer);
    }

    private bool CanSeePlayer()
    {
        Vector3 origin = eyePoint != null ? eyePoint.position : transform.position + Vector3.up;

        Vector3 target = player.position + Vector3.up;
        Vector3 direction = target - origin;

        float distance = direction.magnitude;

        if (distance <= 0.001f)
        {
            return true;
        }

        if (Physics.Raycast(origin, direction.normalized, out RaycastHit hit, distance, visionMask, QueryTriggerInteraction.Ignore))
        {
            return hit.transform == player ||
                   hit.transform.IsChildOf(player);
        }

        return false;
    }

    private void ChasePlayer()
    {
        agent.isStopped = false;
        agent.speed = originalSpeed;
        agent.SetDestination(player.position);

        LookAtPlayer();
    }

    private void Attack()
    {
        if (isAttacking)
        {
            return;
        }

        isAttacking = true;
        isAttack = true;

        agent.isStopped = true;
        agent.ResetPath();

        LookAtPlayer();
    }

    public void EnemyDealDamage()
    {
        Player playerHealth = player.GetComponent<Player>();

        if (playerHealth != null)
        {
            float distance = Vector3.Distance(transform.position, player.position);

            if (distance <= attackRange)
            {
                playerHealth.TakeDamage(attackDamage);
            }
        }
    }

    private void ReturnToStart()
    {
        agent.isStopped = false;
        agent.speed = returnSpeed;
        agent.SetDestination(startPosition);

        if (!agent.pathPending && agent.remainingDistance <= agent.stoppingDistance)
        {
            isReturning = false;
            hasDetectedPlayer = false;
            lostPlayerTimer = 0f;

            agent.isStopped = true;
            agent.ResetPath();
            agent.speed = originalSpeed;
        }
    }

    private void HandleAnimation(bool foundPlayer)
    {
        if (animator == null)
        {
            return;
        }

        animator.SetBool("foundPlayer", foundPlayer);
        animator.SetBool("isAttack", isAttack);
        animator.SetBool("isReturning", isReturning);
    }

    private void LookAtPlayer()
    {
        if (player == null)
        {
            return;
        }

        Vector3 direction = player.position - transform.position;
        direction.y = 0f;

        if (direction.sqrMagnitude > 0.001f)
        {
            Quaternion targetRotation = Quaternion.LookRotation(direction);

            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 5f);
        }
    }

    public void FinishAttack()
    {
        isAttack = false;
        isAttacking = false;

        if (animator != null)
        {
            animator.SetBool("isAttack", false);
        }
    }

    public void EnemyTakeDamage(float damage)
    {
        enemyCurrentHeath -= damage;
        enemyCurrentHeath = Mathf.Max(enemyCurrentHeath, 0f);

        if (enemyCurrentHeath <= 0f)
        {
            EnemyDie();
        }
    }

    private void EnemyDie()
    {
        ScoreControl.totalScore += 100;
        Destroy(gameObject);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, detectionRange);

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);

        if (player != null)
        {
            Vector3 origin = eyePoint != null ? eyePoint.position : transform.position + Vector3.up;

            Vector3 target = player.position + Vector3.up;

            Gizmos.color = CanSeePlayer() ? Color.green : Color.red;
            Gizmos.DrawLine(origin, target);
        }
    }
}
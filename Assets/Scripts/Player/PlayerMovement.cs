using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private float moveSpeed = 4f;
    [SerializeField] private float sprintSpeed = 8f;
    [SerializeField] private float jumpHeight = 2f;
    [SerializeField] private float gravity = -10f;
    [SerializeField] private float backwardSpeed = 2f;

    [Header("Animation")]
    [SerializeField] private GameObject activeChar;
    [SerializeField] private Animator animator;

    [Header("GroundCheck")]
    [SerializeField] private Transform groundCheck;
    [SerializeField] private float groundCheckRadius = 0.2f;
    [SerializeField] private LayerMask groundLayer;

    [Header("Controller")]
    [SerializeField] private CharacterController controller;

    private InputSystem_Actions inputActions;
    private Vector2 moveInput;
    private float verticalVelocity;
    private bool isGrounded;
    private bool isForward;

    private void Awake()
    {
        controller = GetComponent<CharacterController>();
        inputActions = new InputSystem_Actions();
    }

    private void Start()
    {
        if (animator == null)
        {
            animator = activeChar != null ? activeChar.GetComponentInChildren<Animator>() : GetComponentInChildren<Animator>();
        }
    }

    private void OnEnable()
    {
        inputActions.Player.Enable();
    }

    private void OnDisable()
    {
        if (inputActions != null)
        {
            inputActions.Disable();
        }
    }

    private void Update()
    {
        CheckGround();

        HandleMovement();

        HandleJump();

        HandleAnimation();
    }

    private void CheckGround()
    {
        isGrounded = controller.isGrounded ||
            Physics.CheckSphere(groundCheck.position, groundCheckRadius, groundLayer);

        if (isGrounded && verticalVelocity < 0f)
        {
            verticalVelocity = -2f;
        }
    }

    private void HandleMovement()
    {
        moveInput = inputActions.Player.Move.ReadValue<Vector2>();

        Vector3 direction = transform.forward * moveInput.y + transform.right * moveInput.x;

        direction = Vector3.ClampMagnitude(direction, 1f);

        float speed = inputActions.Player.Sprint.IsPressed() ? sprintSpeed : moveSpeed;

        if (moveInput.y < 0)
        {
            isForward = false;

            speed = backwardSpeed;

            if (inputActions.Player.Sprint.IsPressed())
            {
                speed = backwardSpeed;
            }
        }
        else
        {
            isForward = true;

            speed = inputActions.Player.Sprint.IsPressed() ? sprintSpeed : moveSpeed;
        }

        controller.Move(direction * speed * Time.deltaTime);
        
    }

    private void HandleJump()
    {
        if (inputActions.Player.Jump.WasPressedThisFrame() && isGrounded)
        {
            verticalVelocity = Mathf.Sqrt(jumpHeight * -2f * gravity);

            isGrounded = false;
        }

        verticalVelocity += gravity * Time.deltaTime;

        controller.Move(Vector3.up * verticalVelocity * Time.deltaTime);

        if (controller.isGrounded && verticalVelocity <= 0f)
        {
            isGrounded = true;
        }
    }

    private void HandleAnimation()
    {
        if (animator == null)
            return;

        if (moveInput != Vector2.zero)
        {
            animator.SetBool("isWalking", true);
            if (isForward)
            {
                animator.SetBool("walkForward", true);
            }
            else
            {
                animator.SetBool("walkForward", false);
            }
        }
        else
        {
            animator.SetBool("isWalking", false);
        }

        float speed = inputActions.Player.Sprint.IsPressed() ? sprintSpeed : moveSpeed;

        if (moveInput != Vector2.zero && speed > moveSpeed)
        {
            animator.SetBool("isRunning", true);
        }
        else
        {
            animator.SetBool("isRunning", false);
        }
        
    }

}
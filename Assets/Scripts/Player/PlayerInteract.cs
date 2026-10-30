using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerInteract : MonoBehaviour
{
    private InputSystem_Actions inputActions;

    [Header("Interaction")]
    [SerializeField] private Camera playerCamera;
    [SerializeField] private float interactDistance = 4f;
    [SerializeField] private LayerMask chestLayer;

    [Header("Score Settings")]
    [SerializeField] private float requiredScore = 100f;
    [SerializeField] private TMP_Text messageText;

    private Chest currentChest;

    private void Awake()
    {
        inputActions = new InputSystem_Actions();
    }

    private void OnEnable()
    {
        inputActions.Player.Enable();
    }

    private void OnDisable()
    {
        inputActions.Player.Disable();
    }

    private void OnDestroy()
    {
        inputActions.Dispose();
    }

    private void Update()
    {
        CheckInteraction();

        if (currentChest != null &&
            inputActions.Player.Interact.WasPressedThisFrame())
        {
            if (ScoreControl.totalScore >= requiredScore)
            {
                if (messageText != null)
                {
                    messageText.gameObject.SetActive(false);
                }

                currentChest.OpenChest();
            }
            else
            {
                if (messageText != null)
                {
                    messageText.text = "Chưa đủ điểm! Bạn cần đạt 100 điểm để mở rương.";
                    messageText.gameObject.SetActive(true);
                }
            }
        }
    }

    private void CheckInteraction()
    {
        currentChest = null;

        if (playerCamera == null)
        {
            return;
        }

        Ray ray = new Ray(playerCamera.transform.position, playerCamera.transform.forward);

        Debug.DrawRay(ray.origin, ray.direction * interactDistance, Color.red);

        if (Physics.Raycast(ray, out RaycastHit hit, interactDistance, chestLayer))
        {
            currentChest = hit.collider.GetComponentInParent<Chest>();
        }
    }
}
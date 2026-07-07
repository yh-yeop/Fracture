using UnityEngine;

public class player_move : MonoBehaviour
{
    [Header("Move")]
    public float moveSpeed = 5f;

    [Header("State")]
    public bool isCrouching = false;

    private Rigidbody2D rb;
    private float moveInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // A / D 입력
        moveInput = Input.GetAxisRaw("Horizontal");

        // S 입력 시 엎드림 플래그 ON
        if (Input.GetKey(KeyCode.S))
        {
            isCrouching = true;
        }
        else
        {
            isCrouching = false;
        }
    }

    void FixedUpdate()
    {
        // 좌우 이동
        rb.linearVelocity = new Vector2(moveInput * moveSpeed, rb.linearVelocity.y);
    }
}
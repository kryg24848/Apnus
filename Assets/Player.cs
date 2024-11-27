using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f; // 이동 속도

    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // WASD 입력 받기
        movement.x = Input.GetAxisRaw("Horizontal"); // A, D 키: 좌우
        movement.y = Input.GetAxisRaw("Vertical");   // W, S 키: 상하
    }

    void FixedUpdate()
    {
        // Rigidbody2D를 사용하여 이동
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision with: " + collision.gameObject.name);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collision with: " + collision.gameObject.name);
    }
}

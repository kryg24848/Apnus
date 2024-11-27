using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f; // �̵� �ӵ�

    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // WASD �Է� �ޱ�
        movement.x = Input.GetAxisRaw("Horizontal"); // A, D Ű: �¿�
        movement.y = Input.GetAxisRaw("Vertical");   // W, S Ű: ����
    }

    void FixedUpdate()
    {
        // Rigidbody2D�� ����Ͽ� �̵�
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

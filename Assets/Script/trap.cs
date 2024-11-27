using UnityEngine;

public class trap : MonoBehaviour
{
    Rigidbody2D rigi;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rigi = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="Trap")
        {
            OnDamaged(collision.transform.position);
        }
    }
    void OnDamaged(Vector2 targetpos)
    {
        gameObject.layer = 7;
        int dirc=transform.position.x-targetpos.x>0 ? 1 : -1;
        rigi.AddForce(new Vector2(dirc, 1)*3, ForceMode2D.Impulse);
    }
}

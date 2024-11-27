using UnityEngine;

public class Enemy : MonoBehaviour
{
    Rigidbody2D rigid;      // Rigidbody2D 컴포넌트 참조
    public int nextM;       // 이동 방향 (-1, 0, 1 중 하나)
    Vector2 poss;
    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>(); 
        Thik();  
    }

    void FixedUpdate()
    {
        rigid.MovePosition(rigid.position+ poss * Time.fixedDeltaTime);


    }

    void Thik()
    {
        nextM = Random.Range(-1, 2);  // -1, 0, 1 중 랜덤한 값 반환
        poss=new Vector2( nextM, gameObject.transform.position.y);
    }
}

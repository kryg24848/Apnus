using UnityEngine;

public class Enemy : MonoBehaviour
{
    Rigidbody2D rigid;      // Rigidbody2D ������Ʈ ����
    public int nextM;       // �̵� ���� (-1, 0, 1 �� �ϳ�)
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
        nextM = Random.Range(-1, 2);  // -1, 0, 1 �� ������ �� ��ȯ
        poss=new Vector2( nextM, gameObject.transform.position.y);
    }
}

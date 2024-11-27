using UnityEngine;

public class camera : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform target; // ���� ��� (�÷��̾�)
    public float smoothing = 5f; // ī�޶� �������� �ε巯�� ����

    private Vector3 offset=new Vector3(0f, 2f, -10f); // �÷��̾�� ī�޶� ���� �ʱ� �Ÿ� ����

    void Start()
    {
        // ī�޶�� ��� ���� �ʱ� �Ÿ� ���
        offset = transform.position - target.position;
    }

    void LateUpdate()
    {
        // ī�޶��� ���ο� ��ġ ���
        Vector3 targetCamPosition = target.position + offset;

        // �ε巴�� �̵�
        transform.position = Vector3.Lerp(transform.position, targetCamPosition, smoothing * Time.deltaTime);
    }
}

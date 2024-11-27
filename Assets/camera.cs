using UnityEngine;

public class camera : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform target; // 따라갈 대상 (플레이어)
    public float smoothing = 5f; // 카메라 움직임의 부드러움 정도

    private Vector3 offset=new Vector3(0f, 2f, -10f); // 플레이어와 카메라 간의 초기 거리 차이

    void Start()
    {
        // 카메라와 대상 간의 초기 거리 계산
        offset = transform.position - target.position;
    }

    void LateUpdate()
    {
        // 카메라의 새로운 위치 계산
        Vector3 targetCamPosition = target.position + offset;

        // 부드럽게 이동
        transform.position = Vector3.Lerp(transform.position, targetCamPosition, smoothing * Time.deltaTime);
    }
}

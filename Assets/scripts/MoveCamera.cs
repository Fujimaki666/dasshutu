using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform target;
    public float speed = 10.0f;
    private bool isMoving = false;

    void Update()
    {
        if (isMoving)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

            if (Vector3.Distance(transform.position, target.position) < 0.1f)
            {
                isMoving = false;
                gameObject.SetActive(false); // 移動が完了したら再び非アクティブにする
            }
        }
    }

    public void StartMoving()
    {
        gameObject.SetActive(true); // カメラをアクティブ化
        isMoving = true;
    }
}

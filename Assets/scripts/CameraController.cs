using UnityEngine;
using System.Collections;
using System.Diagnostics;

public class CameraController : MonoBehaviour
{
    public GameObject cameraObject;  // 非アクティブのカメラオブジェクト
    public Transform target;         // カメラが向かうターゲット
    public float speed = 2.0f;       // カメラの移動速度

    public void StartMovingCamera()
    {
        // Coroutineでカメラを動かす
        StartCoroutine(MoveCameraCoroutine());
    }

    private IEnumerator MoveCameraCoroutine()
    {
        // カメラがターゲットに十分近づくまで移動を続ける
        while (Vector3.Distance(cameraObject.transform.position, target.position) > 0.1f)
        {
            cameraObject.transform.position = Vector3.MoveTowards(cameraObject.transform.position, target.position, speed * Time.deltaTime);
            yield return null;  // 次のフレームまで待機
        }

        //Debug.Log("Camera reached target.");
    }
}

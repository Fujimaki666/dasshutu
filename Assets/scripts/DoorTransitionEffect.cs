using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorTransitionEffect : MonoBehaviour
{
    public CameraManager cameraManager; // CameraManagerの参照
    public int zoomPositionIndex;       // ズーム先のカメラ位置のインデックス
    public float zoomSpeed = 2f;        // ズーム速度
    public string nextSceneName;        // 遷移するシーンの名前

    private bool isZooming = false;

    public void StartDoorTransition()
    {
        if (!isZooming)
        {
            StartCoroutine(ZoomToDoorAndTransition());
        }
    }

    private IEnumerator ZoomToDoorAndTransition()
    {
        isZooming = true;

        // Cube カメラの Transform を取得
        Transform cameraTransform = Camera.main.transform;

        // ズームターゲットの Transform を取得
        Transform targetPosition = cameraManager.cameraPositions[zoomPositionIndex];

        while (Vector3.Distance(cameraTransform.position, targetPosition.position) > 0.1f)
        {
            // Cube カメラをターゲット位置に向かって移動させる
            cameraTransform.position = Vector3.MoveTowards(cameraTransform.position, targetPosition.position, zoomSpeed * Time.deltaTime);
            cameraTransform.rotation = Quaternion.Slerp(cameraTransform.rotation, targetPosition.rotation, zoomSpeed * Time.deltaTime);
            yield return null;
        }

        // シーン遷移
        SceneManager.LoadScene(nextSceneName);
    }
}

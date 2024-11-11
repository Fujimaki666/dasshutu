using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door_yes : MonoBehaviour
{
    private bool isClicked = false; // フラグを追加
    [SerializeField] Animator animator = default;
    [SerializeField] Animator animator2 = default;
    [SerializeField] GameObject button_yes;
    [SerializeField] GameObject button_no;

    // フラグを設定するメソッド
    public void SetClicked(bool clicked)
    {
        isClicked = clicked;
    }

    // 更新処理
    public void OnClick()
    {
       
        animator.Play("DoorOpen");
        animator2.Play("CameraZoom");

        /*if (animator2 != null)
        {
            StartCoroutine(WaitForDoorAnimationAndZoom());
        }*/
        button_yes.SetActive(false);
        button_no.SetActive(false);
        UnityEngine.Debug.LogError("CLEAR");
        // SceneManager.LoadScene("Clear"); // 遷移するシーン名を正確に指定してください
    }

    /*private IEnumerator WaitForDoorAnimationAndZoom()
    {
        // ドアが開くアニメーションの長さを待つ
        yield return new WaitForSeconds(animator.GetCurrentAnimatorStateInfo(0).length);

        // カメラのズームアニメーションを再生
        animator2.Play("CameraZoom");
    }*/
}

using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public Button leftButton;
    public Button rightButton;
    public GameObject textBox;
    public GameObject objectBox; // 表示したいオブジェクト

    private bool isDisplayingTextOrObject;

    void Start()
    {
        // 初期状態ではボタンを操作可能に設定
        SetButtonInteractable(true);
    }

    void Update()
    {
        // テキストまたはオブジェクトが表示されているかチェック
        isDisplayingTextOrObject = textBox.activeSelf || objectBox.activeSelf;

        // フラグに基づいてボタンを有効または無効に設定
        SetButtonInteractable(!isDisplayingTextOrObject);
    }

    void SetButtonInteractable(bool interactable)
    {
        leftButton.interactable = interactable;
        rightButton.interactable = interactable;
    }
}

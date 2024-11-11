using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDisplay : MonoBehaviour
{
    public string[] texts;      // テキスト配列
    int textNumber;             // 現在表示中のテキスト番号
    string displayText;         // 表示されるテキスト
    int textCharNumber;         // 現在表示中の文字番号
    int displayTextSpeed;       // 文字を表示するスピード制御用
    bool click;                 // クリックされたかのフラグ
    bool textStop;              // テキスト表示が終わったかどうかのフラグ
    bool isRestarting;          // リスタート中かどうかを管理
    [SerializeField] GameObject panel;

    void Start()
    {
        StartTextDisplay(); // 初期化時にテキスト表示をスタート
    }

    void Update()
    {
        if (!textStop)
        {
            displayTextSpeed++;

            // 5フレームごとに1文字ずつ表示する
            if (displayTextSpeed % 5 == 0)
            {
                // リスタート中でなければ、通常のアニメーション処理を続ける
                if (textCharNumber < texts[textNumber].Length)
                {
                    displayText += texts[textNumber][textCharNumber];
                    textCharNumber++;
                }
                else
                {
                    // 次のセリフがある場合
                    if (textNumber < texts.Length - 1)
                    {
                        if (click)
                        {
                            displayText = "";  // 次のセリフに切り替え
                            textCharNumber = 0;
                            textNumber++;
                        }
                    }
                    else
                    {
                        // 最後のセリフが終わったらテキストを止める
                        if (click)
                        {
                            textStop = true;
                            panel.SetActive(false);
                        }
                    }
                }

                // 表示中のテキストを画面に表示
                this.GetComponent<Text>().text = displayText;
                click = false; // クリックフラグをリセット
            }

            // マウスクリックを検出したらフラグを立てる
            if (Input.GetMouseButton(0))
            {
                click = true;
            }
        }
    }

    // テキスト表示を最初からやり直すメソッド
    public void RestartTextDisplay()
    {
        Debug.Log("TextDisplay restarting from the beginning.");
        // 表示中のテキストと制御変数をリセット
        textNumber = 0; // テキスト番号を最初に戻す
        textCharNumber = 0; // 文字番号を最初に戻す
        displayText = "";   // 表示文字列をリセット
        displayTextSpeed = 0; // スピードのカウントをリセット
        textStop = false;   // テキスト表示を再度開始
        isRestarting = false; // リスタート中のフラグをリセット
        this.GetComponent<Text>().text = displayText; // テキストUIをリセット
        panel.SetActive(true); // パネルを再表示
    }

    // テキスト表示を最初に開始するメソッド
    public void StartTextDisplay()
    {
        textNumber = 0;
        displayText = "";
        textCharNumber = 0;
        displayTextSpeed = 0;
        click = false;
        textStop = false;
        isRestarting = false; // 初期化時にはリスタート中ではない
        this.GetComponent<Text>().text = displayText; // テキストを初期化
        panel.SetActive(true); // パネルも再表示
    }
}




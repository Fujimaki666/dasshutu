using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoccerManager : MonoBehaviour
{
    [SerializeField] GameObject soccerButton = default; // 表示するボタン
    [SerializeField] GameObject soccerButton2 = default; // 表示するボタン
    [SerializeField] GameObject panel;
    [SerializeField] GameObject panel_osu;
    [SerializeField] TextDisplay textDisplay;

    private bool hasClicked = false;

    public void ItemClick()
    {

        
        // サッカーアイテムが選択されているか確認
        if (ItemBox.instance.CheckSelectItem(Item.Type.Soccer))
        {
                // ボタンを表示
                soccerButton.SetActive(true);
                soccerButton2.SetActive(true);
                Debug.Log("Soccer item selected.");
                panel_osu.SetActive(true);
                textDisplay.RestartTextDisplay();
        }
            else
            {
                panel.SetActive(true);
                Debug.Log("Soccer item not selected.");
            }

            hasClicked = true; // 二度目以降は実行しない
        
    }

    public void ItemClose()
    {
        Debug.Log("Button closed.");
        Destroy(this.gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorManager : MonoBehaviour
{
    [SerializeField] GameObject Button1 = default; // 表示するボタン
    [SerializeField] GameObject Button2 = default;
    [SerializeField] GameObject Panel_door = default; // 表示するボタン
    [SerializeField] GameObject Panel_door_deru = default; // 表示するボタン
    [SerializeField] TextDisplay textDisplay;

    private bool isClicked = false;

    public void SetClicked(bool clicked)
    {
        isClicked = clicked;
    }

    public void OnClick()
    {
        if (ItemBox.instance.CheckSelectItem(Item.Type.key) && isClicked == true)
        {
            Button1.SetActive(true);
            Button2.SetActive(true);
            //Debug.Log("CLEAR");
            Panel_door_deru.SetActive(true);
            Debug.Log("押した!!!");

        }
        else
        {
            Panel_door.SetActive(true);
            textDisplay.RestartTextDisplay();

        }


        Debug.Log("押された!!!");  // ログを出力

    }
        

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    [SerializeField] GameObject Key;
   // [SerializeField] GameObject get_Key;
    [SerializeField] GameObject panel;
    [SerializeField] GameObject kinko;
    [SerializeField] GameObject fieldObj;
    [SerializeField] TextDisplay textDisplay;
    // public Item.Type type = default;
    // Start is called before the first frame update
    private bool hasClicked = false;
    public void ItemClick()
    {
        if (!hasClicked) // Keyを取得していない場合のみ実行
        {
            kinko.SetActive(true);
            fieldObj.SetActive(true);
            panel.SetActive(true);
            textDisplay.RestartTextDisplay();


        }
    }
    public void ItemClose()
    {
        Debug.Log("bbb");
        Destroy(this.gameObject);
        //get_Key.SetActive(true);
    }
    /*public void SetKeyAcquired()
    {
        hasKey = true; // Keyを取得したことをフラグで記録
        Key.SetActive(true);
    }*/
}

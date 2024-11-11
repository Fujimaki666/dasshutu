using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meron : MonoBehaviour
{
    [SerializeField] GameObject Meron;
    // [SerializeField] GameObject get_Key;
    [SerializeField] GameObject panel;
    [SerializeField] TextDisplay textDisplay;

    public Item.Type type = default;
    // Start is called before the first frame update
    private bool hasClicked = false;
    public void ItemClick()
    {
        if (!hasClicked) // KeyÇéÊìæÇµÇƒÇ¢Ç»Ç¢èÍçáÇÃÇ›é¿çs
        {
            //Item item = ItemDatabase.instance.Spawn(type);
            //ItemBox.instance.SetItem(type);
            Debug.Log("aaa");
            Meron.SetActive(true);
            panel.SetActive(true);
            hasClicked = true;
            textDisplay.RestartTextDisplay();
        }
    }
    public void ItemClose()
    {
        Item item = ItemDatabase.instance.Spawn(type);
        ItemBox.instance.SetItem(type);
        Debug.Log("bbb");
        Destroy(this.gameObject);
        Meron.SetActive(false);
        //get_Key.SetActive(true);
    }
}

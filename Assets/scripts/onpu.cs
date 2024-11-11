using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onpu : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject Onpu;
    // [SerializeField] GameObject get_Key;
    [SerializeField] GameObject panel;
    [SerializeField] GameObject Onpu2;
    [SerializeField] TextDisplay textDisplay;

    public Item.Type type = default;
    // Start is called before the first frame update
    private bool hasClicked = false;
    public void ItemClick3()
    {
        if (!hasClicked) // KeyÇéÊìæÇµÇƒÇ¢Ç»Ç¢èÍçáÇÃÇ›é¿çs
        {
            //Item item = ItemDatabase.instance.Spawn(type);
            //ItemBox.instance.SetItem(type);
            Debug.Log("aaa");
            Onpu.SetActive(true);
            panel.SetActive(true);
            hasClicked = true;
            textDisplay.RestartTextDisplay();

        }
    }
    public void ItemClose3()
    {
        Item item = ItemDatabase.instance.Spawn(type);
        ItemBox.instance.SetItem(type);
        Debug.Log("bbb");
        Destroy(this.gameObject);
        Destroy(Onpu2);
        //get_Key.SetActive(true);
    }
}

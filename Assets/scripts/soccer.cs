using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soccer : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject Soccer;
    [SerializeField] GameObject Soccer2;
    //[SerializeField] GameObject get_soccer;
    [SerializeField] GameObject panel2;
    [SerializeField] TextDisplay textDisplay;

    public Item.Type type = default;
    // Start is called before the first frame update
    public void ItemClick()
    {
        
        Debug.Log("aaa");
        
        Item item = ItemDatabase.instance.Spawn(type);
        ItemBox.instance.SetItem(type);
        Soccer.SetActive(false);
        Soccer2.SetActive(true);
        panel2.SetActive(true);
        textDisplay.RestartTextDisplay();
    }
   /* public void ItemClose()
    {
        Debug.Log("bbb");
        
        Soccer2.SetActive(false);
        //get_soccer.SetActive(true);
    }*/
}

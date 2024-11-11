using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soccer2 : MonoBehaviour
{
    //[SerializeField] GameObject get_soccer;
    //[SerializeField] GameObject panel2;
    [SerializeField] GameObject Soccer2;
    //public Item.Type type = default;
    // Start is called before the first frame update
    /*public void ItemClick()
    {

        Debug.Log("aaa");

        Item item = ItemDatabase.instance.Spawn(type);
        ItemBox.instance.SetItem(type);
        Soccer.SetActive(false);
        Soccer2.SetActive(true);
        //panel2.SetActive(true);

    }*/

    public void Destroy()
    {
        Destroy(this.gameObject);
    }

}

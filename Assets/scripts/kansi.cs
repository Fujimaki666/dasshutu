using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class kansi : MonoBehaviour
{
    [SerializeField] GameObject setItemObj;

    public UnityEvent SetEvent;
    public void OnClickObj()
    {
        if (ItemBox.instance.CheckSelectItem(Item.Type.Soccer))
        {
            ItemBox.instance.UseSelectItem();
            ItemSet();

        }
    }

    public void ItemSet()
    {
        Debug.Log("set");
        setItemObj.SetActive(true);
        //SetEvent.Invoke();
    }
}

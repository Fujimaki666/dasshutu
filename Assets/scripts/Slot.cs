using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    [SerializeField] GameObject backPanel = default;
    [SerializeField] Image image = default;
    Item item = null;
    private void Start()
    {
        backPanel.SetActive(false);
    }
    public void Set(Item item)
    {
        this.item = item;
        image.sprite = item.sprite;
    }
    public void RemoveItem()
    {
        item = null;
        image.sprite = null;
        HideBackPanel();

    }

    public Item GetItem()
    {
        return item;
    }
    public bool IsEmpty()
    {
        if (item == null)
        {
            return true;
        }
        return false;
    }
    public void OnSelect()
    {
        backPanel.SetActive(true);
    }

    public void HideBackPanel()
    {
        backPanel.SetActive(false);
    }
}
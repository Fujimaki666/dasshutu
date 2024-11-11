using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    [SerializeField] Slot[] slots = default;
    //[SerializeField] GameObject Panel4;

    //どこからでもアクセスできるようにする変数
    public static ItemBox instance;
    Slot selectSlot;
    private Item.Type selectedItemType;
    private void Awake()
    {
        instance = this;
    }
    //クリックした時アイテムを受け取る
    public void SetItem(Item.Type type ) //public void SetItem(Item.Type type)
    {
        
            Item item = ItemDatabase.instance.Spawn(type);
            for (int i = 0; i < slots.Length; i++)
            {
                Slot slot = slots[i];
                if (slot.IsEmpty())
                {
                    slot.Set(item);
                    
                    break;
                }
            }
        
    }
    public void OnSlotClick(int position)
    {
        //アイテムがない場合実行しない
        if (slots[position].IsEmpty())
        {
            return;
        }
        //一度BackPanelを全て消す
        for (int i = 0; i < slots.Length; i++)
        {
            slots[i].HideBackPanel();

        }
        //クリックしたスロットのBackPanelを表示する
        slots[position].OnSelect();
        //選択アイテムとして取得する
        selectSlot = slots[position];

        // 選択されたアイテムの種類を設定
        selectedItemType = selectSlot.GetItem().type;
        
    }

    //アイテムを選択しているかを判定する関数
    public bool CheckSelectItem(Item.Type useItemType)
    {
        if (selectSlot == null)
        {
            return false;

        }
        if (selectSlot.GetItem().type == useItemType)
        {
            return true;
        }
        

        return false;

    }

    public void UseSelectItem()
    {
        selectSlot.RemoveItem();
        selectSlot = null;
    }
}

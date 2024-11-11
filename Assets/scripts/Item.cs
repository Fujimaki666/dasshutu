using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]//inspectorで表示できるようにする
public class Item
{
    //アイテムの種類
    public enum Type
    {
        key,
        Soccer,
        Book,
        curry,
        onpu,
        Meron,
        Panel4,
        //アイテムを追加する場合ここに書き足す
    }
    public Type type;
    public Sprite sprite;

    public Item(Item item)
    {
        this.type = item.type;
        this.sprite = item.sprite;
    }
}
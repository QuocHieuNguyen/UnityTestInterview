using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ShopItemData
{
    public string id;
    public string icon;
    public string title;
    public string description;
    public string price;

    public ShopItemData(string id, string icon, string title, string desc, string price){
        this.id = id;
        this.icon = icon;
        this.title = title;
        this.description = desc;
        this.price = price;
    }
}
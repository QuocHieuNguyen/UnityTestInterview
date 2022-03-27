using System.Collections;
using System.Collections.Generic;
using PooledScrollList.Data;
using PooledScrollList.View;
using UnityEngine;
using UnityEngine.UI;
using System;

namespace PooledScrollList.PooledShopItem
{
    [Serializable]
    public class PooledShopItem : PooledData
    {
        public string id;
        public string icon;
        public string title;
        public string desc;
        public string price;
        public Sprite sprite;

        public ShopItemData shopItemData;
        public ItemDetailHandler handler;

    }
    public class PooledShopItemView : PooledView
    {
        public Image Image;
        public Text itemName;
        public Text itemPrice;
        public ShopItemData shopItemData;
        public ItemDetailHandler handler;

        public override void SetData(PooledData data)
        {
            base.SetData(data);
            Debug.Log("Set Data");
            var pooledShopItemData = (PooledShopItem) data;
            Image.sprite = pooledShopItemData.sprite;
            itemName.text = pooledShopItemData.title;
            itemPrice.text = pooledShopItemData.price;
            shopItemData = pooledShopItemData.shopItemData;
            handler = pooledShopItemData.handler;

                
        }
    }
}

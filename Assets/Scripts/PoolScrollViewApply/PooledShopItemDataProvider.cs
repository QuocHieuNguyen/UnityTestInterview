using System.Collections;
using System.Collections.Generic;
using PooledScrollList.Controller;
using PooledScrollList.Data;
using UnityEngine;

namespace PooledScrollList.PooledShopItem
{
    public class PooledShopItemDataProvider : PooledDataProvider
    {
        [SerializeField]
        private DataManager dataManager;
        [SerializeField]
        private ItemDetailHandler handler;
        public PooledScrollRectBase ScrollRectController;
        public int Count;

        private void Awake()
        {
        }

        public override List<PooledData> GetData()
        {
            List<ShopItemData> shopItemDatas = dataManager.shopItemDatas;
            var data = new List<PooledData>(shopItemDatas.Count);

            for (var i = 0; i < Count; i++)
            {
                ShopItemData temp = shopItemDatas[i];
                data.Add(new PooledShopItem { 
                    id = temp.id,
                    price = temp.price, 
                    title = temp.title,
                    icon = temp.icon,
                    desc =temp.description,
                    sprite = temp.sprite,
                    shopItemData = temp,
                    handler = handler
                    });
            }

            return data;
        }
    }
}

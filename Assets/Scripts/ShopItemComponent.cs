using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PooledScrollList.PooledShopItem;

public class ShopItemComponent : MonoBehaviour
{
    private ShopItemData shopItemData;
    private ItemDetailHandler handler;

    private PooledShopItemView pooledShopItemView;
    private void Start() {
        var viewComponent = gameObject.GetComponent<PooledShopItemView>();
        pooledShopItemView = viewComponent;
        if (viewComponent){
            handler = viewComponent.handler;
            shopItemData = viewComponent.shopItemData;

        }
    }
    public void ButtonClicked(){
        if (pooledShopItemView){
            Debug.Log("The data is changed");
            shopItemData = pooledShopItemView.shopItemData;
        }
        handler.AssignData(shopItemData);
        handler.OpenDetailTab();
    }

    public void Init(ShopItemData data, ItemDetailHandler handler){
        this.shopItemData = data;
        this.handler = handler;
        
    }
}

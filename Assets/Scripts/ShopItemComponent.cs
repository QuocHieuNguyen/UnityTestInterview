using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopItemComponent : MonoBehaviour
{
    private ShopItemData shopItemData;
    private ItemDetailHandler handler;
    public void ButtonClicked(){
        handler.AssignData(shopItemData);
        handler.OpenDetailTab();
    }
    public void Init(ShopItemData data, ItemDetailHandler handler){
        this.shopItemData = data;
        this.handler = handler;
        
    }
}

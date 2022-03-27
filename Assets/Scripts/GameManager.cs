using System.Collections;
using System.Collections.Generic;
using frame8.ScrollRectItemsAdapter.Classic.Examples;
using PooledScrollList.Controller;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public DataManager dataManager;
    public ShopItemGridView shopItemGridView;

    public PooledScrollRectShopItemGridController pooledScrollRectShopItemGridController;
    // Start is called before the first frame update
    void Start()
    {
        // dataManager.LoadShopItemData();
        // shopItemGridView.Init(dataManager.shopItemDatas);

    }


}

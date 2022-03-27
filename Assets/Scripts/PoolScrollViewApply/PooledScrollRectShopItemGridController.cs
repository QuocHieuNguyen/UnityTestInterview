using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PooledScrollList.Controller
{
    public class PooledScrollRectShopItemGridController : PooledScrollRectGridController
    {
        [SerializeField]
        private DataManager dataManager;
        protected override void Awake()
        {
            dataManager.LoadShopItemData();
            base.Awake();
        }
        
    }
}

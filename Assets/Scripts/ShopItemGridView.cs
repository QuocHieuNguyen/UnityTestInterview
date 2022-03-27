using System.Collections;
using System.Collections.Generic;
using frame8.ScrollRectItemsAdapter.Classic.Examples.Common;
using UnityEngine;
using UnityEngine.UI;

namespace frame8.ScrollRectItemsAdapter.Classic.Examples {
    public class ShopItemGridView : ClassicSRIA<ShopItemCellViewsHolder> {

		public RectTransform itemPrefab;
        [SerializeField]
        public List<ShopItemCellModel> Data;
        public DataManager dataManager;
        [SerializeField]
        private ItemDetailHandler itemDetailHandler;
        protected override void Awake()
		{
			base.Awake();

			Data = new List<ShopItemCellModel>();
		}
        // Start is called before the first frame update
        protected override void Start () {
            base.Start ();
            // ChangeModelsAndReset(20);
            dataManager.LoadShopItemData();
            Init(dataManager.shopItemDatas);
        }
        public void Init(List<ShopItemData> shopItemDatas){
            for (int i = 0; i < shopItemDatas.Count; i++)
            {
                ShopItemCellModel item = new ShopItemCellModel();
                item.shopItemData = shopItemDatas[i];
                item.title = shopItemDatas[i].title;
                item.price = shopItemDatas[i].price;
                Data.Add(item);
                    // Get sprite from local
                    Texture2D itemImageTexture = dataManager.LoadImageByName(shopItemDatas[i].icon);
                    // Create sprite from texture2D
                    //Sprite imageSprite = item.image.sprite;
                    Rect rec = new Rect(0, 0, 90, 89);
                    item.image =Sprite.Create(itemImageTexture,rec,new Vector2(0.5f,0.5f),100);
                    shopItemDatas[i].SetSprite(item.image);                    
                
            }
            ResetItems(20);
            // ChangeModelsAndReset(20);
        }
        protected override ShopItemCellViewsHolder CreateViewsHolder (int itemIndex) {
			var instance = new ShopItemCellViewsHolder();
			instance.Init(itemPrefab, itemIndex);
            instance.root.GetComponent<ShopItemComponent>().Init(Data[itemIndex].shopItemData, itemDetailHandler);
			return instance;
        }
        protected override void UpdateViewsHolder (ShopItemCellViewsHolder vh) {
            var model = Data[vh.ItemIndex];
            vh.titleText.text =  model.title;
            vh.priceText.text =  model.price;
            vh.image.sprite = model.image;
            vh.shopItemData = model.shopItemData;
            Debug.Log("Updated Value");
        }
        void ChangeModelsAndReset(int newCount)
		{
			Data.Clear();
			Data.Capacity = newCount;
			for (int i = 0; i < newCount; i++)
			{
				var model = CreateNewModel();
				Data.Add(model);
			}

			ResetItems(Data.Count);
		}
        ShopItemCellModel CreateNewModel()
		{
			int imgIdx = 0;
			var model = new ShopItemCellModel()
			{
				title = "Image "+ imgIdx,
				imageIndex = imgIdx,
			};

			return model;
		}

    }
    [System.Serializable]
    public class ShopItemCellModel {
        public string title;
        public int imageIndex;
        public string price;
        public Sprite image;

        public ShopItemData shopItemData;
    }

    public class ShopItemCellViewsHolder : CAbstractViewsHolder {
        public Text titleText;
        public Image image;
        public Text priceText;
        public ShopItemData shopItemData;

        public GameObject itemPrefab;

        public override void CollectViews () {
            base.CollectViews();

            titleText = root.Find("ItemNameText").GetComponent<Text>();
            image = root.Find("ItemImage/Image").GetComponent<Image>();
            priceText = root.Find("PriceText").GetComponent<Text>();
        }

    }
}
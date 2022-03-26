using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;
public class DataManager : MonoBehaviour
{
    [SerializeField]
    private TextAsset textAsset;
    [SerializeField]
    public List<ShopItemData> shopItemDatas = new List<ShopItemData>();
    // Start is called before the first frame update
    void Start()
    {
        // LoadShopItemData();
    }

    public void LoadShopItemData(){
        Debug.Log(textAsset.text);
        JSONNode jsonData = JSON.Parse(textAsset.text);
        // SaveToJsonFile(webData.downloadHandler.text);
        JSONNode shopItemsDataJson = jsonData["items"];
        for (int i = 0; i < shopItemsDataJson.Count; i++)
        {
            ShopItemData shopItemData = new ShopItemData(
                shopItemsDataJson[i]["id"],
                shopItemsDataJson[i]["icon"],
                shopItemsDataJson[i]["title"],
                shopItemsDataJson[i]["desc"],
                shopItemsDataJson[i]["price"]
            );
            shopItemDatas.Add(shopItemData);
        }
    }
}

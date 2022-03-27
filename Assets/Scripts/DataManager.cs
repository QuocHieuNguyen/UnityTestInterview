using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using SimpleJSON;
using System;

public class DataManager : MonoBehaviour
{
    [SerializeField]
    private TextAsset textAsset;
    [SerializeField]
    public List<ShopItemData> shopItemDatas = new List<ShopItemData>();
    // Start is called before the first frame update
    void Awake()
    {

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
            Texture2D itemImageTexture = LoadImageByName(shopItemsDataJson[i]["icon"]);
            // Create sprite from texture2D
            Rect rec = new Rect(0, 0, 90, 89);
            Sprite sprite =Sprite.Create(itemImageTexture,rec,new Vector2(0.5f,0.5f),100);
            shopItemData.SetSprite(sprite);
            shopItemDatas.Add(shopItemData);
        }
    }
    public Texture2D LoadImageByName(string name,  Action onImageReady = null){
        // string savedPath = Application.dataPath + "/Resources/ShopItems/" + name +".png";
        var texture = Resources.Load<Texture2D>("ShopItems/" + name);
        if (texture){
            Debug.Log("The card image file exists");
            Texture2D texture2D = texture;
            if (onImageReady != null)
                onImageReady();
            return texture2D;
        }else{
            Debug.Log("There is no card image file");
            return null;
        }
    }
    // Texture2D LoadFromFile(string path){
    //     byte [] fileData = File.ReadAllBytes(path);
    //     Texture2D texture = new Texture2D(200,200);
    //     texture.LoadImage(fileData);
    //     Debug.Log("Load Image from File");
    //     return texture;
    // }
}

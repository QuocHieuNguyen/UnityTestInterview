using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemDetailHandler : MonoBehaviour
{
    [SerializeField]
    private GameObject itemDetailContainer;
    [SerializeField]
    private Text itemNameText;
    [SerializeField]
    private Text itemDescText;
    [SerializeField]
    private Image itemImage;
    private ShopItemData data;
    public void AssignData(ShopItemData data){
        this.data = data;
    }
    public void OpenDetailTab(){
        itemNameText.text = data.title;
        itemDescText.text = data.description;
        itemImage.sprite = data.sprite;
        itemDetailContainer.SetActive(true);
    }
    public void CloseDetailTab(){
        itemDetailContainer.SetActive(false);
    }

}

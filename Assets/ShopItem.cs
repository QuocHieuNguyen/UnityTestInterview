using UnityEngine;
using System.Collections;

public class ShopItem : UI.RecyclerView<ShopItem.Holder>.Adapter {

    public override int GetItemCount()
    {
        throw new System.NotImplementedException();
    }

    public override void OnBindViewHolder(Holder holder, int i)
    {
        throw new System.NotImplementedException();
    }

    public override GameObject OnCreateViewHolder()
    {
        throw new System.NotImplementedException();
    }

    public class Holder : ViewHolder
    {
        public Holder(GameObject itemView) : base(itemView)
        {
        }
    }
}



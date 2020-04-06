using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Item Data", menuName = "ScriptableObjectDataContainer/Item Data", order = 0)]
public class ItemData : ScriptableObject {

    public string ItemName;
    public float ItemId;
    public string ItemCategory;

}

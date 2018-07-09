using UnityEngine;

public class ItemData : MonoBehaviour
{
    public BackPack Inventory;
    public string SaveToString()
    {
        return JsonUtility.ToJson(Inventory);
    }
}

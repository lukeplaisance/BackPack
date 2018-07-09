using UnityEngine;
using System.IO;

public class StoreDataBehaviour : MonoBehaviour
{
    public ItemData itemData = new ItemData();

    public void StoreData()
    {
        itemData.pos = transform.position;
        string path = System.IO.Path.Combine(Application.streamingAssetsPath, "itemData.json");
        string json = JsonUtility.ToJson(itemData);
        File.WriteAllText(path, json);
    }

    public void LoadData()
    {
        string path = System.IO.Path.Combine(Application.streamingAssetsPath, "itemData.json");
        var data = File.ReadAllText(path);
        itemData = JsonUtility.FromJson<ItemData>(data);
    }
}

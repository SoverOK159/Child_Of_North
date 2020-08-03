using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] int inventoryCount;
    [SerializeField] List<string> items = new List<string>();

    private void Start()
    {
        inventoryCount = 4;
    }

    public bool AddItem(string itemName)
    {
        if(items.Count != inventoryCount) 
        {
            items.Add(itemName);
            return true;
        }
        else
        {
            Debug.Log("No free space");
            return false;
        }
    }

    public void RemoveItems(string itemName)
    {
        items.Remove(itemName);
    }

    public bool CheckForItem(string itemName)
    {
        foreach (var item in items)
        {
            if(item == itemName)
            {
                Debug.Log(item);
                RemoveItems(item);
                return true;
            }
        }
        return false;
    }


}

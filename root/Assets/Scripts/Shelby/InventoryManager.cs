using UnityEngine;
using System.Collections;

public class InventoryManager : MonoBehaviour 
{
    //public Inventory inventory;

    void ListResources(Inventory inv)
    {
        print("Scraps:         " + inv.scraps);
        print("Special Scraps: " + inv.scraps_special);
    }


    void ListItemNames(Inventory inv)
    {
        for (int i = 0; i < inv.items.Count; ++i)
            print(inv.items[i].GetComponent<ItemData>().name);
    }

    void ListItemIDs(Inventory inv)
    {
        for (int i = 0; i < inv.items.Count; ++i)
            print(inv.items[i].GetComponent<ItemData>().id);
    }

    void ListItemsAll(Inventory inv)
    {
        for (int i = 0; i < inv.items.Count; ++i)
        {
            print(inv.items[i].GetComponent<ItemData>().name);
            print(inv.items[i].GetComponent<ItemData>().id);
        }
        ListResources(inv);
    }

}

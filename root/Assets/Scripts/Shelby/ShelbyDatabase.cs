using UnityEngine;
using System.Collections;

public  class ShelbyDatabase : Singleton<ShelbyDatabase> 
{
 
    //public Inventory inventory;
    /*
    public void ListResources(ItemDatabase inv)
    {
       // print("Scraps:         " + inv.scraps);
        //print("Special Scraps: " + inv.scraps_special);
    }


    public void ListItemNames(ItemDatabase inv)
    {
        for (int i = 0; i < inv.items.Count; ++i)
            print(inv.items[i].GetComponent<Item>().name);
    }

    public void ListItemIDs(ItemDatabase inv)
    {
        for (int i = 0; i < inv.items.Count; ++i)
            print(inv.items[i].GetComponent<Item>().id);
    }

    public void ListItemsAll(ItemDatabase inv)
    {
        for (int i = 0; i < inv.items.Count; ++i)
        {
            print(inv.items[i].GetComponent<Item>().name);
            print(inv.items[i].GetComponent<Item>().id);
        }

        ListResources(inv);
    }
 */

    /// <summary>
    /// Query for a database that has names in it
    /// </summary>
    /// <param name="db">
    /// the database to look through
    /// </param>
    /// <returns>
    /// a big ass string of names in the format "name0 name1 name2..."
    /// </returns>
    public string SelectAllNames(ItemDatabase db)
    {
        string Names = "";
        for (int i = 0; i < db.database.Count; ++i)
        {
            Names += db.database[i].GetComponent<Item>().name + ",\n";
        }
        Names.Remove(Names.Length - 2, 2);
        return Names;
    }

    public string SelectAllIDs(ItemDatabase db)
    {
        string IDs = "";
        for (int i = 0; i < db.database.Count; ++i)
        {
            IDs += db.database[i].GetComponent<Item>().id.ToString() + ",\n";
        }
        IDs.Remove(IDs.Length - 2, 2);
        return IDs;
    }
}

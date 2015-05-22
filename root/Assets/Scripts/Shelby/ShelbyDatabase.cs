using UnityEngine;
using System.Collections;

public  class ShelbyDatabase : Singleton<ShelbyDatabase> 
{
    public string SelectAllNames(ItemDatabase db)
    {
        string Names = "";
        for (int i = 0; i < db.database.Count; ++i)
        {
            Names = Names += db.database[i].GetComponent<Item>().name + ",\n";
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
        IDs = IDs.Remove(IDs.Length - 2, 2);
        return IDs;
    }
}

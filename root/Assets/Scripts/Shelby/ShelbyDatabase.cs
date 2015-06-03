using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public  class ShelbyDatabase : Singleton<ShelbyDatabase> 
{
    //public List<GameObject> _databases = new List<GameObject>();
    //void Awake()
    //{
    //    GameObject[] dbs = FindObjectsOfType(typeof(Database)) as GameObject[];
    //    foreach(GameObject d in dbs)
    //    {
    //        _databases.Add(d);
    //    }        
    //}

    public string SelectAllNames(Database db)
    {
        string Names = "";
        for (int i = 0; i < db.database.Count -1; ++i)
        {
            Names += db.database[i].GetComponent<EquipmentStats>().name + ",\n";
        }
        //Names = Names.Remove(Names.Length - 2, 2);
        Names += db.database[db.database.Count].GetComponent<EquipmentStats>().name;
        return Names;
    }

    public string SelectAllIDs(Database db)
    {
        string IDs = "";
        for (int i = 0; i < db.database.Count -1; ++i)
        {
            IDs += db.database[i].GetComponent<EquipmentStats>().id.ToString() + ",\n";
        }
        //IDs = IDs.Remove(IDs.Length - 2, 2);
        IDs += db.database[db.database.Count].GetComponent<EquipmentStats>().id.ToString();
        return IDs;
    }

    public void AddListToDatabase(Database db)
    {

    }

    public void AddSingleItem(GameObject o, Database db)
    {
        db.database.Add(o);
    }
}

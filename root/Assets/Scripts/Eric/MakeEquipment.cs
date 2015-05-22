using UnityEngine;
using System.Collections;
using EquipmentTypes;

public class MakeEquipment : MonoBehaviour
{
    public GameObject equipment;

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Instantiate(equipment).GetComponent<EquipmentStats>().Build(1);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player");
            //Destroy(gameObject);
    }
}

using UnityEngine; 
using System.Collections; 
using System.Collections.Generic; 
using System.IO; 

public class EquipmentDatabase : MonoBehaviour  
{
	public List<ItemDatabase> equipment = new List<ItemDatabase>(); 

	void Start() 
	{ 
		for (i = 0; i < ItemDatabase.Count; i++)
		{
			if(ItemDatabase[i].itemIsEquipment)
			{
				equipment.add(ItemDatabase[i]);
			}
		}
    }
}

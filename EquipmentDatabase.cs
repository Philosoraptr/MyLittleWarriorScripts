using UnityEngine; 
using System.Collections; 
using System.Collections.Generic; 
using System.IO; 

public class EquipmentDatabase : MonoBehaviour  
{
	public List<ItemDatabase> equipmentDatabase = new List<ItemDatabase>(); 
	
	public ItemDatabase itemDatabase;

	void Start() 
	{ 
		itemDatabase = GameObject.FindGameObjectWithTag ("Item Database").GetComponent<ItemDatabase>();
		
		for (i = 0; i < itemDatabase.items.Count; i++)
		{
			if(itemDatabase.items[i].itemIsEquipment)
			{
				equipmentDatabase.add(ItemDatabase[i]);
			}
		}
    }
}

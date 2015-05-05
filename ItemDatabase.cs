using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class ItemDatabase : MonoBehaviour 
{
	public List<Item> items = new List<Item>();

	void Start()
	{
		items.Add(new Item(0, "Leather Chest", "Leather Chest", 0, 10, 10, false, true, Item.ItemEquipmentType.Armour, Item.ItemGender.Male));
//		items.Add(new Item(1, "Gold Chest", "Gold Chest", 0, 20, 10, false, true, Item.ItemEquipmentType.Armour, Item.ItemGender.Male));
		items.Add(new Item(2, "Red Pants", "Red Pants", 0, 20, 10, false, true, Item.ItemEquipmentType.Legs, Item.ItemGender.Male));
    }

//	// Use this for initialization
//	void Start () 
//	{
//		DirectoryInfo dir = new DirectoryInfo("Assets/Resources/Male/Armour");
//		FileInfo[] info = dir.GetFiles("*.*");
//		int i = 0;
//		foreach (FileInfo file in info) 
//		{
//			if(file.Extension == ".png")
//			{
//				string itemName = Path.GetFileNameWithoutExtension(file.Name);
//				Debug.Log(itemName);
////				items.Add(new Item(i, itemName, 
//				i++;
//			}
//		}
//	}
}

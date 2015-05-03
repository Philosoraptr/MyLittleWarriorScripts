using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class Item 
{
	public int itemId;
	public string itemName;
	public string itemDescription;
	public int itemAttack;
	public int itemDefence;
	public int itemSpeed;
	public Sprite itemIcon;
	public bool itemIsActive;
	public bool itemIsConsumable;
	public bool itemIsEquipment;
	public ItemEquipmentType itemEquipmentType;
	public ItemGender itemGender;

	public enum ItemEquipmentType 
	{
		Weapon,
		Shield,
		Hat,
		Clothes,
		Mail,
		Armour,
		Legs,
		Greaves,
		Shoes,
		Arms,
		Shoulders,
		Bracers,
		Gloves,
		Belt
	}

	public enum ItemGender
	{
		Male,
		Female
	}

	public Item(int id, string name, string description, int attack, int defence, int speed, bool isConsumable, bool isEquipment, ItemEquipmentType equipmentType, ItemGender gender)
	{
		itemId = id;
		itemName = name;
		itemDescription = description;
		itemAttack = attack;
		itemDefence = defence;
		itemSpeed = speed;
		itemIsConsumable = isConsumable;
		itemIsEquipment = isEquipment;
		itemEquipmentType = equipmentType;
		itemGender = gender;
		itemIcon = Resources.LoadAll<Sprite> (itemGender + "/" + itemEquipmentType + "/" + itemName + "/" + itemEquipmentType + "_14")
	}
	// Should create some constructors for item
}


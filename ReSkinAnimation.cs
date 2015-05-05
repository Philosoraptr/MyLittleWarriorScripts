using UnityEngine;
using System;

public class ReSkinAnimation : MonoBehaviour {

	public string bodySheetName;

	private string gender = "Male";

	void Start()
	{
		PlayerPrefs.SetString ("Gender", gender);
	}

	void LateUpdate()
	{
		bodySheetName = PlayerPrefs.GetString("Body");

		if(PlayerPrefs.HasKey("Armour"))
		{
            string armourSheetName = PlayerPrefs.GetString("Armour");
			UpdateSprites("Armour", armourSheetName);
        }
	
		if(PlayerPrefs.HasKey("Clothes"))
		{
			string clothesSheetName = PlayerPrefs.GetString("Clothes");
			UpdateSprites("Clothes", clothesSheetName);
        }

		if(PlayerPrefs.HasKey("Legs"))
		{
			string legsSheetName = PlayerPrefs.GetString("Legs");
			UpdateSprites("Legs", legsSheetName);
        }

//		var subSprites = Resources.LoadAll<Sprite> ("Male/Body/" + bodySheetName);
//
//		foreach(var renderer in GetComponentsInChildren<SpriteRenderer>())
//		{
//			string spriteName = renderer.sprite.name;
//			var newSprite = Array.Find(subSprites, item => item.name == spriteName);
//
//			if(newSprite)
//			{
//				renderer.sprite = newSprite;
//			}
//		}
	}

	void UpdateSprites(string folder, string spriteSheetName)
	{
		var subSprites = Resources.LoadAll<Sprite> (gender + "/" + folder +"/" + spriteSheetName);
		
		foreach(var renderer in GetComponentsInChildren<SpriteRenderer>())
		{
			// I think Sprite Renderer is the renderer that the script is attached to. Need to remember this will be different for each piece of the character.
			string spriteName = renderer.sprite.name;
			var newSprite = Array.Find(subSprites, item => item.name == spriteName);
			
			if(newSprite)
            {
                renderer.sprite = newSprite;
            }
        }
	}
}

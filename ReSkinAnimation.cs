using UnityEngine;
using System;

public class ReSkinAnimation : MonoBehaviour {

	public string bodySheetName;
	private string gender = "Male";
// The name of the GameObject will be the name of the sprite body part that will have it's sprite updated to the correct item.
// The GameObject name is also the name of the folder in which the sprites are stored 
	private string objectName = GameObject.name;

	void Start()
	{
		PlayerPrefs.SetString ("Gender", gender);
	}

	void LateUpdate()
	{
// Will need to come up with a name for "Body". Maybe just leave it as Sprite, considering this is already coded in animations.
//		bodySheetName = PlayerPrefs.GetString("Body");

		if(PlayerPrefs.HasKey(objectName))
		{
            string armourSheetName = PlayerPrefs.GetString(objectName);
			UpdateSprites(objectName, armourSheetName);
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

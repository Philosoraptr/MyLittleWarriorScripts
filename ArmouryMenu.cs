using UnityEngine;
using System.Collections;

public class ArmouryMenu : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		//sort of pseudo code at this stage
		for int i = 1 to numberOfSpriteSheets
		{
			buttonLabel = SpriteSheet.Name;
			Sprite Sprites = Resources.Load <Sprite> ("Characters/" + spriteSheetName + "/Sprite_07");
			buttonImage = Sprite;
		}
		
		var subSprites = Resources.LoadAll<Sprite> ("Characters/" + spriteSheetName);
		
		foreach(var renderer in GetComponentsInChildren<SpriteRenderer>())
		{
			string spriteName = renderer.sprite.name;
			var newSprite = Array.Find(subSprites, item => item.name == spriteName);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

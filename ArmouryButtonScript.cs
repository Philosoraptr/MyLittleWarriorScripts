using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ArmouryButtonScript : MonoBehaviour
{
	public Button button;
	public Text nameLabel;
	public Image icon;
//	public Text typeLabel;
//	public Text rarityLabel;
//	public GameObject championIcon;

	public void SetArmour () 
	{
		PlayerPrefs.SetString ("Armour", nameLabel.text);
		Debug.Log (nameLabel.text);
	}
}


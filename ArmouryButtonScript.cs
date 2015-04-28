using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ArmouryButtonScript : MonoBehaviour
{
	public Button button;
	public Text nameLabel;
	public Image icon;
	public GameObject activeIcon;
//	public Text typeLabel;
//	public Text rarityLabel;
//	public GameObject championIcon;

	public void SetArmour () 
	{
//		string prevArmour = PlayerPrefs.GetString ("Armour");

		PlayerPrefs.SetString ("Armour", nameLabel.text);
		Debug.Log (nameLabel.text);
		this.activeIcon.SetActive (true);
		int instanceID = this.GetInstanceID ();
		Debug.Log(instanceID);
	}
}


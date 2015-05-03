using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ArmouryButtonScript : MonoBehaviour
{
	public Button button;
	public Text nameLabel;
	public Image icon;
	public GameObject activeIcon;
	private int instanceId;
//	public Text typeLabel;
//	public Text rarityLabel;
//	public GameObject championIcon;

	public void SetArmour ()
	{
		PlayerPrefs.SetString ("Armour", nameLabel.text);
		Debug.Log (nameLabel.text);
		this.activeIcon.SetActive (true);
		instanceId = this.GetInstanceID ();
		Debug.Log(instanceId);
	}
}


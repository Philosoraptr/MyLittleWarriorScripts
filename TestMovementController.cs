using UnityEngine;
using System.Collections;

public class TestMovementController : MonoBehaviour {

	private string[] classes = new string[]
	{
		"Leather With Hat", "Robe With Hood", "Gold Knight With Helm", "Metal Knight No Helm", "White Monk"
	};
	private int counter = 0;
	private int counterMax = 0;
	private GameObject character;
	private GameObject weapon;
	Animator anim;
	Animator weaponAnim;
	private Vector2 initialSpeed;

	// Use this for initialization
	void Start () 
	{
		character = GameObject.Find("Character");
		weapon = GameObject.Find ("Weapon");
		counterMax = classes.Length;
		Repeater();
		anim = character.GetComponent<Animator>();
		weaponAnim = weapon.GetComponent<Animator> ();
		initialSpeed = character.GetComponent<WarriorController> ().speed;
	}

	void Update()
	{
	}

	public void ChangeClassLoop()
	{
		counter++;
		if(counter == counterMax)
		{
			counter = 0;
		}
		ChangeClass();
	}

	public void ChangeClass()
	{
		character.GetComponent<ReSkinAnimation>().spriteSheetName = classes[counter];
	}
	
	void Repeater()
	{
		InvokeRepeating("ChangeClassLoop", 10.0f, 10.0f);
	}

	public void PlayAttackAnimation()
	{
		Vector2 movement = character.GetComponent<WarriorController> ().movement;
		float initialMovement = movement.x;
		character.GetComponent<WarriorController> ().speed = new Vector2 (0, 0);
		if(initialMovement > 0.0f)
		{
			anim.SetTrigger ("cast");
			weapon.renderer.enabled = false;
		}
		else
		{
			anim.SetTrigger("slash");
			weaponAnim.SetTrigger("weaponSlash"); //doesn't work!
		}
		StartCoroutine ("WaitAfterAttack");
	}

	IEnumerator WaitAfterAttack()
	{
		yield return new WaitForSeconds (1);
		character.GetComponent<WarriorController>().speed = initialSpeed;
		weapon.renderer.enabled = true;
	}
}

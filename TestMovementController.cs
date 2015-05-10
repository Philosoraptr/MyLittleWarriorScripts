using UnityEngine;
using System.Collections;

public class TestMovementController : MonoBehaviour {
	
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
		anim = character.GetComponent<Animator>();
		weaponAnim = weapon.GetComponent<Animator> ();
		initialSpeed = character.GetComponent<WarriorController> ().speed;
	}

	public void PlayAttackAnimation()
	{
		Vector2 movement = character.GetComponent<WarriorController> ().movement;
		float initialMovement = movement.x;
		character.GetComponent<WarriorController> ().speed = new Vector2 (0, 0);
		if(initialMovement > 0.0f)
		{
			anim.SetTrigger ("cast");
			weapon.GetComponent<Renderer>().enabled = false;
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
		weapon.GetComponent<Renderer>().enabled = true;
	}
}

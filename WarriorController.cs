using UnityEngine;
using System.Collections;

public class WarriorController : MonoBehaviour 
{
	public Vector2 speed = new Vector2(5, 0);
	public Vector2 direction = new Vector2(-1, 0);
	public Vector2 movement;

	public GameObject body;
//	public GameObject hat;

	private Animator bodyAnim;
//	private Animator hatAnim;

	private bool touchingEnemy;
	public float coolDown;
	private float attackTimer;
	
	void Start ()
	{
		bodyAnim = body.GetComponent<Animator> ();
//		hatAnim = hat.GetComponent<Animator> ();
		touchingEnemy = false;
		coolDown = 2.0f;
		attackTimer = 0;
    }

	void Update ()
	{
		movement = new Vector2(speed.x * direction.x, speed.y * direction.y);
		bodyAnim.SetFloat ("speed", movement.x);
//		hatAnim.SetFloat ("speed", movement.x);

		if(touchingEnemy)
		{
			if(attackTimer > 0)
				attackTimer -= Time.deltaTime;

			Debug.Log("Attack Timer=" + attackTimer);

			if(attackTimer < 0)
				attackTimer = 0;

			if(attackTimer == 0)
			{
				Attack ();
				attackTimer = coolDown;
			}
		}
    }
    
    void FixedUpdate()
	{
		GetComponent<Rigidbody2D>().velocity = movement;
    }

	void OnTriggerEnter2D(Collider2D otherCollider)
	{
		touchingEnemy = true;
		Debug.Log ("Collided!");
	}
	// could also use OnTriggerExit2D to turn off a bool when moving away

	void OnTriggerExit2D(Collider2D otherCollider)
	{
		touchingEnemy = false;
		bodyAnim.SetBool ("cast", false);
		Debug.Log ("Exit Collision!");
	}

	void Attack()
	{
		Debug.Log("InsideAttack() Timer=" + attackTimer);

		bodyAnim.SetBool ("cast", true);
		GameObject.Find("Left Button").GetComponent<PointerListener> ().animPlaying = true;
		GameObject.Find("Right Button").GetComponent<PointerListener> ().animPlaying = true;
//		GameObject.Find ("Weapon").GetComponent<Animator> ().SetBool ("cast", true);
		StartCoroutine(WaitThenStopAnimation(coolDown));
	}

	IEnumerator WaitThenStopAnimation(float waitTime)
	{
		Debug.Log("Ienumerator1 Timer=" + attackTimer);

		yield return new WaitForSeconds (waitTime);

		Debug.Log("Ienumerator2 Timer=" + attackTimer);

		bodyAnim.SetBool ("cast", false);
		GameObject.Find("Left Button").GetComponent<PointerListener> ().animPlaying = false;
		GameObject.Find("Right Button").GetComponent<PointerListener> ().animPlaying = false;
	}
}

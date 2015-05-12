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
//		When the character is walking backwards and forwards
//		if(otherCollider.name == "BoxSprite")
//		{
//			direction.x *= -1;
//		}
		Debug.Log ("Collided!");
	}
	// could also use OnTriggerExit2D to turn off a bool when moving away

	void OnCollisionStay2D(Collision2D collision)
	{
		touchingEnemy = true;
		Debug.Log ("Collisions!");
	}

	void Attack()
	{
		//animation = GameObject.Find ("Body").GetComponent<Animation>("CastRight");
		//animation = GameObject.Find ("Weapon").GetComponent<Animation>("CastRight");
		//animation.Play();
		GameObject.Find ("Body").GetComponent<Animator> ().SetBool ("cast", true);
		GameObject.Find ("Weapon").GetComponent<Animator> ().SetBool ("cast", true);
		StartCoroutine(WaitThenStopAnimation(animation.clip.length));
	}

	IEnumerator WaitThenStopAnimation(float waitTime)
	{
		yield return new WaitForSeconds (waitTime);
		GameObject.Find ("Body").GetComponent<Animator> ().SetBool ("cast", false);
	}
}

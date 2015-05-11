using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class PointerListener : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
	public GameObject player;
	public float directionX;

	bool pressed = false;

	public void OnPointerDown(PointerEventData eventData)
	{
		pressed = true;
		MoveX (directionX);
	}
	
	public void OnPointerUp(PointerEventData eventData)
	{
		pressed = false;
		MoveX (0.0);
	}
	
	// Needs to stop moving on release. Perhaps the variables in WarriorController shouldn't stay set.
/*	void Update()
	{
		if (!pressed)
		{
			MoveX(0);
			return;
		}
		
		MoveX (directionX);
	}
*/
	public void MoveX(float direction)
	{
		player.GetComponent<WarriorController> ().direction.x = direction;
	}
}

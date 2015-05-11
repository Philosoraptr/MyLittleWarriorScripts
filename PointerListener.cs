using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class PointerListener : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
	public GameObject player;
	public float directionX;

	public void OnPointerDown(PointerEventData eventData)
	{
		MoveX (directionX);
	}
	
	public void OnPointerUp(PointerEventData eventData)
	{
		MoveX (0.0f);
	}

	public void MoveX(float direction)
	{
		player.GetComponent<WarriorController> ().direction.x = direction;
	}
}

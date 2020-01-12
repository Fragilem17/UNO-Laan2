using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnTrigger : MonoBehaviour
{
	public UnityEvent OnTriggerEntered;

	private void OnTriggerEnter(Collider other)
	{
		Debug.Log("other: " + other.gameObject.name);
		OnTriggerEntered?.Invoke();
	}
}

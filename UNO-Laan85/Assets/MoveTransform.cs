using OculusSampleFramework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTransform : MonoBehaviour
{
	public Transform source;
	public Transform target;

	public MeshRenderer materialMesh;
	//public Color activeColor;
	//public Color disabledColor;

	//private Material material;

	private void Start()
	{
		//material = materialMesh.material;
		materialMesh.enabled = false;
		//material.SetColor("_Color", disabledColor);
	}

	public void Transport(InteractableStateArgs args)
	{
		if (args.NewInteractableState == InteractableState.ContactState)
		{
			materialMesh.enabled = true;
			//material.SetColor("_Color", activeColor);
		}

		if (args.NewInteractableState == InteractableState.ProximityState)
		{
			//material.SetColor("_Color", activeColor);
			materialMesh.enabled = true;
		}

		if (args.NewInteractableState == InteractableState.Default)
		{
			//material.SetColor("_Color", disabledColor);
			materialMesh.enabled = false;
		}

		if (args.NewInteractableState == InteractableState.ActionState)
		{
			source.position = target.position;
			//material.SetColor("_Color", disabledColor);
			materialMesh.enabled = false;
		}
	}
}

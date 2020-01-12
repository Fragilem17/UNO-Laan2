using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
	public List<MeshRenderer> meshes;
	public int materialIndex = 0;

	private int _index = 0;

	[ColorUsage(true, true)]
	public List<Color> EmissionColors;

	public void Change()
	{
		foreach (MeshRenderer mesh in meshes) {

			Material m = mesh.materials[materialIndex];
			m.DOColor(EmissionColors[_index], "_EmissionColor", 0f).Kill(true);
			DynamicGI.SetEmissive(mesh, EmissionColors[_index]);			

			Debug.Log("tweening color: " + m.name);
		}

		_index++;
		if (_index > EmissionColors.Count-1)
		{
			_index = 0;
		}
	}
}

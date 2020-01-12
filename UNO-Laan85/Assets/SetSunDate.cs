using Entropedia;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSunDate : MonoBehaviour
{
	public Sun sun;
	private int _index = 0;
	public List<MyDate> dates;

	public void Change()
	{
		sun.gameObject.SetActive(true);
		sun.enabled = true;

		MyDate d = dates[_index];
		sun.SetTime(new DateTime(2020, d.month, d.day, d.hour, d.minutes, 0));

		_index++;
		if (_index > dates.Count - 1)
		{
			_index = 0;
		}
	}
}

[Serializable]
public class MyDate {
	[SerializeField]
	[Range(1, 12)]
	public int month;

	[SerializeField]
	[Range(1, 31)]
	public int day;

	[SerializeField]
	[Range(0, 24)]
	public int hour;

	[SerializeField]
	[Range(0, 60)]
	public int minutes;
}

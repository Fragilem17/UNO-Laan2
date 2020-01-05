using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyController : MonoBehaviour
{
	public static MyController Instance;

    // Start is called before the first frame update
    void Start()
    {
		Instance = this;
	}
}

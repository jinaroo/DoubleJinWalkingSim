using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnOffGame : MonoBehaviour {
	//turns off game
	void Update()
	{
		if (Input.GetKey("escape"))
		{
			Application.Quit();
		}
	}
}

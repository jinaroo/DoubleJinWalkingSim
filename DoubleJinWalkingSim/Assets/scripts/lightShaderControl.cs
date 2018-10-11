using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightShaderControl : MonoBehaviour
{

	public GameObject plantLight;

	// Use this for initialization
	void Start () {
		plantLight.SetActive(false);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			Debug.Log("Player is in trigger!");
			plantLight.SetActive(true);
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			Debug.Log("Player is not in trigger!");
			//plantLight.SetActive(false);
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}

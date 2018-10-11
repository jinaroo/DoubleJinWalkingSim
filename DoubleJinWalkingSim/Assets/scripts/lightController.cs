﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightController : MonoBehaviour
{

	public GameObject plantLight;
	public GameObject lightSparks;

	// Use this for initialization
	void Start () {
		plantLight.SetActive(false);
		lightSparks.SetActive(false);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			Debug.Log("Player is in trigger!");
			plantLight.SetActive(true);
			lightSparks.SetActive(true);
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

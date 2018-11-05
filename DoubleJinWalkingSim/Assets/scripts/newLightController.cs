﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newLightController : MonoBehaviour
{
	public GameObject plantLightInitial;
	public GameObject plantLightChange;
	public GameObject plantLightMax;
	public GameObject lightSparks;
	public float maxGlowAmount;
	
	private bool startGlow;

	private float glowAmount = 0f;
	// Use this for initialization
	void Start () {
		plantLightInitial.SetActive(true);
		plantLightChange.SetActive(false);
		plantLightMax.SetActive(false);
		lightSparks.SetActive(false);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			Debug.Log("Player is in trigger!");
			// First We need to switch the Plant Light Initial with Plant Light Change
			plantLightInitial.SetActive(false);
			plantLightChange.SetActive(true);
			
			// Then need to activate the plantlightChange material glow
			startGlow = true;
			lightSparks.SetActive(true);
			
			// Need to glitch screen for x seconds
			StartCoroutine(startGlitching(GameManager.GM.planGlitchTime));
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

	IEnumerator startGlitching(float time)
	{
		GameManager.GM.changeCameraGlitch();
		yield return new WaitForSeconds(time);
		GameManager.GM.resetCameraGlitch();
	}

	// Update is called once per frame
	void Update()
	{
		if (startGlow)
		{
			plantLightChange.GetComponentInChildren<Renderer>().material.SetFloat("_MKGlowPower", glowAmount);
			glowAmount += Time.deltaTime;
		}

		if (glowAmount >= maxGlowAmount)
		{
			startGlow = false;
			glowAmount = 0f;
			plantLightChange.SetActive(false);
			plantLightMax.SetActive(true);
		}
	}
}
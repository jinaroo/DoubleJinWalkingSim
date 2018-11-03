using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class caveSoundController : MonoBehaviour
{
	private AudioLowPassFilter rbLowPass;
	private AudioDistortionFilter rbDistortion;
	private AudioEchoFilter rbEcho;

	private bool inCave;

	void Start()
	{
		rbLowPass = GameObject.Find("MainCamera").GetComponent<AudioLowPassFilter>();
		rbDistortion = GameObject.Find("MainCamera").GetComponent<AudioDistortionFilter>();
		rbEcho = GameObject.Find("MainCamera").GetComponent<AudioEchoFilter>();
		
		rbLowPass.enabled = false;
		rbDistortion.enabled = false;
		rbEcho.enabled = false;

		inCave = false;

	}
	
	void Update()
	{
		//if (inCave)
		//{
		//	rbLowPass.cutoffFrequency -= 100;
		//}
	}
	
	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			Debug.Log("Player is in cave!");
			inCave = true;
			
			rbLowPass.enabled = true;
			rbDistortion.enabled = true;
			rbEcho.enabled = true;
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			Debug.Log("Player is not in cave.");
			inCave = false;
			
			rbLowPass.enabled = false;
			rbDistortion.enabled = false;
			rbEcho.enabled = false;
			
		}
	}
}

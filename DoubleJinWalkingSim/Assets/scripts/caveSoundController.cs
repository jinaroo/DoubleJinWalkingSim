using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class caveSoundController : MonoBehaviour
{
	private AudioLowPassFilter rbLowPass;
	private AudioDistortionFilter rbDistortion;
	private AudioEchoFilter rbEcho;

	void Start()
	{
		rbLowPass = GameObject.Find("MainCamera").GetComponent<AudioLowPassFilter>();
		rbDistortion = GameObject.Find("MainCamera").GetComponent<AudioDistortionFilter>();
		rbEcho = GameObject.Find("MainCamera").GetComponent<AudioEchoFilter>();
		
		rbLowPass.enabled = false;
		rbDistortion.enabled = false;
		rbEcho.enabled = false;

	}
	
	void Update()
	{
		//GetComponent<AudioListener>().
	}
	
	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			Debug.Log("Player is in cave!");
			
			rbLowPass.enabled = true;
			rbDistortion.enabled = true;
			rbEcho.enabled = true;
			
			//rbLowPass.cutoffFrequency = 400;
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			Debug.Log("Player is not in cave.");
			rbLowPass.enabled = false;
			rbDistortion.enabled = false;
			rbEcho.enabled = false;
			
		}
	}
}

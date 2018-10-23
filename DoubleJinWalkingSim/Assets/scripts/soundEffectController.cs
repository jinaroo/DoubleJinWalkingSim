using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundEffectController : MonoBehaviour
{
	public AudioSource musicNote;
	private bool isFirst = true;

	private void Start()
	{

	}

	void OnTriggerEnter(Collider other)
	{
		if (isFirst && other.CompareTag("Player"))
		{
			isFirst = false;
			musicNote.Play();
		}
		
		isFirst = true;
	}
}
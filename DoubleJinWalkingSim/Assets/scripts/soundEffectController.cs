using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundEffectController : MonoBehaviour
{
	public AudioSource soundEffect;
	private bool isFirst = true;

	void OnTriggerEnter(Collider other)
     	{	
     		if (isFirst && other.CompareTag("Player"))
     		{
     			isFirst = false;
     			soundEffect.Play();
     		}
     	}
}
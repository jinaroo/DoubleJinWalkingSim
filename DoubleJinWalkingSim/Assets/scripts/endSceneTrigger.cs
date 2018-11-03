using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endSceneTrigger : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
	{	
		if (other.CompareTag("Player"))
		{
			Debug.Log("Player is in trigger!");
			UnityEngine.SceneManagement.SceneManager.LoadScene ("endScreen");
		}
	}
}

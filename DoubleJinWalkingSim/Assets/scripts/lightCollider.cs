using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightCollider : MonoBehaviour
{

	public GameObject lampLight;
	public bool isPlayerInTrigger; //just a redundant check right now, may use later
	
	//NOTES
	//1. create an empty gameObject and add a box collider (make sure "is trigger" is on)
	//2. attach this script to the new gameObject
	//3. in the slot "lamp light," drag in the light you want to use
	
	void Start () {
		lampLight.SetActive(false); //when game starts, lights are turned off
	}
	
	void OnTriggerEnter (Collider other)
	{
		//if player enters the trigger the light turns on
		if (other.CompareTag("Player")) {
			isPlayerInTrigger = true;
			Debug.Log("Player is in lightTrigger.");
			//lampLight.GetComponent<Light>().enabled = true;
			lampLight.SetActive(true);
		}		
	}

	void OnTriggerExit(Collider other)
	{
		//if player leaves the trigger the light turns off
		isPlayerInTrigger = false;
		Debug.Log("Player is not in lightTrigger.");
		//lampLight.GetComponent<Light>().enabled = false;
		lampLight.SetActive(false);
	}	
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveGlitchControl : MonoBehaviour
{
	public float maxScanLineJitter;
	public float maxColorDrift;
	public Transform Player;
	
	private bool startGlitch = false;
	private float colliderRadius;

	private void Start()
	{
		colliderRadius = GetComponent<SphereCollider>().radius;
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			// Start the glitch
			startGlitch = true;
		}
	}

	private void Update()
	{
		if (startGlitch)
		{
			float distanceToPlayer = Vector3.Distance(transform.position, Player.position);
			float percentDistance = 1f - (distanceToPlayer / colliderRadius);
			Camera.main.GetComponent<Kino.AnalogGlitch>().scanLineJitter = maxScanLineJitter * percentDistance;
			Camera.main.GetComponent<Kino.AnalogGlitch>().colorDrift = maxColorDrift * percentDistance;
		}
	}
}

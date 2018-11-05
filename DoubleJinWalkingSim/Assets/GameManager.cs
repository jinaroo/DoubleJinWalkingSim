using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

	public static GameManager GM;
	public float ScanLineJitter;
	public float VerticalJump;
	public float HorizontalShake;
	public float ColorDrift;
	public float planGlitchTime;

	private void Awake()
	{
		GM = this;
	}

	public void changeCameraGlitch()
	{
		Camera.main.gameObject.GetComponent<Kino.AnalogGlitch>().scanLineJitter = ScanLineJitter;
		Camera.main.gameObject.GetComponent<Kino.AnalogGlitch>().verticalJump = VerticalJump;
		Camera.main.gameObject.GetComponent<Kino.AnalogGlitch>().horizontalShake = HorizontalShake;
		Camera.main.gameObject.GetComponent<Kino.AnalogGlitch>().colorDrift = ColorDrift;
	}

	public void resetCameraGlitch()
	{
		Camera.main.gameObject.GetComponent<Kino.AnalogGlitch>().scanLineJitter = 0f;
		Camera.main.gameObject.GetComponent<Kino.AnalogGlitch>().verticalJump = 0f;
		Camera.main.gameObject.GetComponent<Kino.AnalogGlitch>().horizontalShake = 0f;
		Camera.main.gameObject.GetComponent<Kino.AnalogGlitch>().colorDrift = 0f;
	}
}

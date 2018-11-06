using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameStart : MonoBehaviour
{

	public float ScanLineJitter;
	public float VerticalJump;
	public float ColorDrift;

	public float time2Glitch;
	public float timeFromGlitch2Load;
	
	private bool _clicked = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//to start game
		if (!_clicked)
		{
			if (Input.GetKeyDown(KeyCode.Space))
			{
				_clicked = true;
				StartCoroutine(startScene(time2Glitch, timeFromGlitch2Load));
			}
		}
	}

	IEnumerator startScene(float time1, float time2)
	{
		yield return new WaitForSeconds(time1);
		Camera.main.GetComponent<Kino.AnalogGlitch>().scanLineJitter = ScanLineJitter;
		Camera.main.GetComponent<Kino.AnalogGlitch>().verticalJump = VerticalJump;
		Camera.main.GetComponent<Kino.AnalogGlitch>().colorDrift = ColorDrift;

		yield return  new WaitForSeconds(time2);
		UnityEngine.SceneManagement.SceneManager.LoadScene ("ArtStyleTest_Seperate");

	}
}

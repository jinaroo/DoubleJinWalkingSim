using UnityEngine;
using UnityEngine.SceneManagement;

public class screenFadeController : MonoBehaviour
{

	public Animator animator;
	private int levelToLoad; //equals to levelIndex used for fadeToLevel 
	private int currentScene;
	
	// Update is called once per frame
	void Update ()
	{
		currentScene = SceneManager.GetActiveScene().buildIndex;
		
		//to change from title screen to game level
		if (currentScene == 0 && Input.GetKeyDown(KeyCode.Return))
		{
			fadeToLevel(1); //should fade to level index 1
			//fadeToNextLevel(); //fades to next level; but maybe don't use this
		}
	}

	//fades into level
	public void fadeToLevel (int levelIndex) //find level index in build settings
	{
		levelToLoad = levelIndex;
		animator.SetTrigger("fadeOut"); //should fade out
	}

	//when fade finishes, load new level
	//see animation event under fadeOut in animation; event calls onFadeComplete function
	public void onFadeComplete()
	{
		SceneManager.LoadScene(levelToLoad);
	}
	
	//below function changes level based on index level
	public void fadeToNextLevel()
	{
		//gets index of current scene plus one to get next scene in index
		fadeToLevel(SceneManager.GetActiveScene().buildIndex + 1);
	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public string gameLevel;
	public GameObject playButton;
	public GameObject howToPlayButton;
	public GameObject exitButton;
	public GameObject exitHelpButton;
	public GameObject tutorialText;
	public GameObject title;
	public GameObject tutorialBg;

	public void PlayGame(){
		SceneManager.LoadScene("level_02");
	}

	public void ExitGame(){
		Application.Quit();
	}
		

	public void viewTutorial()
	{
		playButton.SetActive(false);
		howToPlayButton.SetActive(false);
		exitButton.SetActive(false);
		title.SetActive (false);
		exitHelpButton.SetActive(true);
		tutorialText.SetActive (true);
		tutorialBg.SetActive (true);
	}

	public void exitTutorial()
	{
		playButton.SetActive(true);
		howToPlayButton.SetActive(true);
		exitButton.SetActive(true);
		title.SetActive (true);
		exitHelpButton.SetActive(false);
		tutorialText.SetActive (false);
		tutorialBg.SetActive (false);
	}
}



using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SelectMenu : MonoBehaviour {

	public GameObject startButton;

	public void PlayGame(){
		SceneManager.LoadScene("level_01");
	}

	public void BackToMenu(){
		SceneManager.LoadScene("MainMenu");

	}
		
}



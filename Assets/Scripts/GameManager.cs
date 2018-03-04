using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static GameManager instance;
	public Transform platformSpawnerTrans;
	private Vector3 platformStartPos;

//	public PlayerController player;
//	private Vector3 playerStart;
//	private ObjectDestroyer[] platformList;
//	private ScoreManager scoreManager;
//	private CoinManager coinManager;
//	private PlatformSpawner platformSpawner;
//	public DeathMenu deathMenu;

	void Awake()
	{
		instance = this;


	}


	void Start () {
//		platformStartPos = platformSpawnerTrans.position;
//		playerStart = player.transform.position;
//		scoreManager = FindObjectOfType<ScoreManager> ();
//		coinManager = FindObjectOfType<CoinManager> ();
//		AudioManager.instance.PlayBackgroundMusic ();
//		platformSpawner = FindObjectOfType<PlatformSpawner> ();
	
	}


	// Update is called once per frame
	void Update () {
	
	}

	public void RestartGame()
	{
//		AudioManager.instance.PlayDeathSound ();
//		scoreManager.playerAlive = false;
//		player.gameObject.SetActive (false);
//		deathMenu.gameObject.SetActive (true);
//		platformSpawner.noObstacleActive = false;
//		platformSpawner.noObstacleTimer = 10;
//		coinManager.doubleCoinsTimer = 10;
//		coinManager.doubleCoinsActive = false;


	}

	public void ResetGameState()
	{
//		deathMenu.gameObject.SetActive (false);
//		platformList = FindObjectsOfType<ObjectDestroyer> ();
//		for (int i = 0; i < platformList.Length; i++)
//		{
//			platformList [i].gameObject.SetActive (false);
//		}
//		player.transform.position = playerStart;
//		platformSpawnerTrans.position = platformStartPos;
//		player.runSpeed = 7;
//		player.gameObject.SetActive (true);
//		scoreManager.scoreCounter = 0;
//		coinManager.coinCounter = 0;
//		scoreManager.playerAlive = true;

	}
		
}


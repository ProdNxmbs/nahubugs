using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour {
	public GameObject gameOverText;
	public bool gameOver = false;
	public static GameControl instance;
	public float scrollSpeed = -1.5f;

	void Awake () {

		if (instance == null) {
			instance = this;
		} else if (instance != null) {
			Destroy (gameObject);
		
		}
	}
	
	void Update () {
		if (gameOver == true && Input.GetMouseButtonDown (0)) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		
		}
		
	}

	public void BirdDied(){
		gameOverText.SetActive (true);
		gameOver = true;
	
	}
}

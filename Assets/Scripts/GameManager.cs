using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public static GameManager gm;

    public Text scoreText;

    public GameObject playAgainButtons;
    public string playAgainLevelToLoad;

    public GameObject ball;
    public GameObject gameOverUi;

    private int score;

    // Use this for initialization
    void Start () {

        score = 0;

        if (gm == null)
            gm = this.gameObject.GetComponent<GameManager>();

    }

    public void addScore()
    {
        score++;

        scoreText.text = "SCORE: " + score;
        ball.GetComponent<BallMover>().Reset();
    }

    public void EndGame()
    {
        Destroy(ball);
        gameOverUi.SetActive(true);
    }

    public void RestartGame()
    {
        // we are just loading a scene (or reloading this scene)
        // which is an easy way to restart the level
        SceneManager.LoadScene(playAgainLevelToLoad);

        // obsolete
        //Application.LoadLevel (playAgainLevelToLoad);
    }

    // Update is called once per frame
    void Update () {
	
	}
}

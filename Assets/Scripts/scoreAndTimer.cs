using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class scoreAndTimer : MonoBehaviour
{
    public int score = 0;
    public int time = 90;

    public Text scoreText;
    public Text timerText;
    public bool gameOver = false;

    public GameObject UI;
    public Text finalScore;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        UI.SetActive(false);
        StartCoroutine(Countdown());
    }

    IEnumerator Countdown() {
        while(time > 0) {
            yield return new WaitForSeconds(1);
            time--;
        }
        gameOver = true;
        GameOver();
        Debug.Log("Game Over!");
    }

    void Update() {
        scoreText.text = "$" + score;
        timerText.text = "Steal as much as you can!\n\nBut be quick, the police will\n be here in " + time + " seconds!";
    }

    void GameOver() {
        UI.SetActive(true);
        finalScore.text = "$" + score;

        Invoke("Restart", 10);
    }

    void Restart() {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
}

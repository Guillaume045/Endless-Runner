using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mouvement : MonoBehaviour
{
    public float seed = 10;
    public UnityEvent<GameObject> Player;
    public Text Score;
    public int nombre = 0;

    private bool isGamePaused = false;

    void Start()
    {
        StartCoroutine(IncreaseScoreOverTime());
    }

    void Update()
    {
        if (!isGamePaused)
        {
            float moveX = 0; //Input.GetAxis("Horizontal");
            float moveY = Input.GetAxis("Vertical");
            Vector2 mouvement = new Vector2(moveX, moveY);
            transform.Translate(mouvement * Time.deltaTime * seed);
            Score.text = "Score : " + nombre.ToString();
        }
    }

    IEnumerator IncreaseScoreOverTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            nombre++;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("obstacle"))
        {
            PlayerPrefs.SetInt("Score", nombre);
            PauseGame();
            //Destroy(gameObject);
            Player.Invoke(this.gameObject);
            SceneManager.LoadScene(2);
        }
    }

    private void PauseGame()
    {
        Time.timeScale = 0f;
        isGamePaused = true;
    }
}

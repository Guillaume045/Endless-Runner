using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class score : MonoBehaviour
{
    public UnityEvent<GameObject> Player;
    public Text Score;
    public int nombre = 0;

    void Start()
    {
        PlayerPrefs.DeleteAll();
        int score = PlayerPrefs.GetInt("Score");
        Debug.Log("Score chargé dans la nouvelle scène : " + score);
    }

    void Update()
    {
        
    }
}

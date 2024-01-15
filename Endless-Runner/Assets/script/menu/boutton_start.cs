using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class boutton_start : MonoBehaviour
{
    public Button votreBouton;

    void Start()
    {
        votreBouton.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        Debug.Log("Le bouton a été cliqué");
        SceneManager.LoadScene(1);
        Debug.Log("Vous allez en jeu");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Boutton_menu : MonoBehaviour
{
    public Button votreBouton;
    // Start is called before the first frame update
    void Start()
    {
        votreBouton.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            SceneManager.LoadScene(0);
        }
    }

    void TaskOnClick()
    {
        //Debug.Log("Le bouton a été cliqué");
        SceneManager.LoadScene(0);
        Debug.Log("Vous allez au menu");
    }
}
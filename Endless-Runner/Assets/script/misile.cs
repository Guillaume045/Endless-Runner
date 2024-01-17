using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class misile : MonoBehaviour
{
    public GameObject objetAParaitre;
    private Vector3 positionDepart;
    public float seed = 10;

    void Start()
    {
        positionDepart = transform.position;
        float delaiAleatoire = Random.Range(8f, 15f);
        Invoke("ApparaitreObjet", delaiAleatoire);
    }

    void Update()
    {
        Vector2 mouvement = new Vector2(-1, 0);
        transform.Translate(mouvement * Time.deltaTime * seed);
    }

    void ApparaitreObjet()
    {
        //Debug.Log("Objet à instancier : " + objetAParaitre);
        Instantiate(objetAParaitre, positionDepart, Quaternion.identity);
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    public void KillJoueur(GameObject go)
    {
        Debug.Log("Collision");
        Destroy(go);
    }
}
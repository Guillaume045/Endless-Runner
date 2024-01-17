using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monstre : MonoBehaviour
{
    public GameObject objetAParaitre;
    private Vector3 positionDepart;
    public float seed = 10;
    public float R1 = 2;
    public float R2 = 3;

    void Start()
    {
        positionDepart = transform.position;
        float delaiAleatoire = Random.Range(R1, R2);
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

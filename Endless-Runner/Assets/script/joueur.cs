using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class mouvement : MonoBehaviour
{
    public float seed = 10;
    public UnityEvent<GameObject> Player;
    void Start()
    {
    }

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        Vector2 mouvement = new Vector2(moveX, moveY);
        transform.Translate(mouvement * Time.deltaTime * seed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("obstacle"))
        {
            Debug.Log("Collision");
            //Destroy(gameObject);
            Player.Invoke(this.gameObject);
        }
    }
}

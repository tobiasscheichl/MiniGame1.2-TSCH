using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{

    private const string AXISVERTICAL = "Vertical";
    private float moveSpeed = 2.0f;




    private void Move()
    {
        var deltaY = Input.GetAxis(AXISVERTICAL) * Time.deltaTime * moveSpeed;
        var newPosY = Mathf.Clamp(transform.position.x + deltaY, -300f, 300f);


     
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Triggerevent" + collision.gameObject.name);

        if (collision.gameObject.name == "Player")
        {

            transform.position +10f;
            Debug.Log("score+" + transform.position);
        }
        else if (collision.gameObject.name == "GedachteLinie")
        {
            transform.position -10f;
            Debug.Log("score-" + transform.position);
        }
    }





    void Update()
    {

        Move();
    }
}

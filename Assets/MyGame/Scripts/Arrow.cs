using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{

    private const string AXISVERTICAL = "Vertical";
    private float moveSpeed = 2.0f;
    private Transform myTransform;
    public ScoreData scoreData;

    private void Start()
    {
        myTransform = gameObject.GetComponent<Transform>();
    }


    private void Move()
    {
        // var deltaY = Input.GetAxis(AXISVERTICAL) * Time.deltaTime * moveSpeed;
        //var newPosY = Mathf.Clamp(transform.position.x + deltaY, -300f, 300f);
        myTransform.position = new Vector3(transform.position.x, transform.position.y + 10f, transform.position.z);


    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Triggerevent" + collision.gameObject.name);

        if (collision.gameObject.name == "Player")
        {
            myTransform.position = new Vector3(transform.position.x, transform.position.y + 10f, transform.position.z);
            Debug.Log("score+" + myTransform.position.y);
        }
        else if (collision.gameObject.name == "GedachteLinie")
        {
            myTransform.position = new Vector3(transform.position.x, transform.position.y + 10f, transform.position.z);
            Debug.Log("score-" + myTransform.position.y);
        }
    }





    void Update()
    {

        Move();
    }
}

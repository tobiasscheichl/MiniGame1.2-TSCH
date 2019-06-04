using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun : MonoBehaviour {



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "ColliderBottom")
        {
            Destroy(gameObject);
        }
        else if(collision.gameObject.name == "Player")
        {
            Destroy(gameObject);
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

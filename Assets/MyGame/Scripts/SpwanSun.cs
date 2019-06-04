using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwanSun : MonoBehaviour
{

    public Sun sunPrefab;
    public GameObject sunParent;

    private void Update()
    {
        //SpawnMySun();
    }

    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            SpawnMySun();
        }

    }

    private void SpawnMySun()
    {
        Sun sunClone = (Sun)Instantiate(sunPrefab, transform.position, transform.rotation);
        float sunSize = 2;
        sunClone.transform.localScale = new Vector3(sunSize, sunSize, 0f);
        sunClone.transform.SetParent(sunParent.transform);
        sunClone.transform.localPosition = new Vector3(UnityEngine.Random.Range(-5f, 5f), sunParent.transform.position.y, 0f);
        sunClone.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-2, 2), UnityEngine.Random.Range(-10, -1));
    }

}

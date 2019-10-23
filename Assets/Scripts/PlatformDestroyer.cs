using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDestroyer : MonoBehaviour
{
    public GameObject platformDestroyerPoints;

    private void Start()
    {
        platformDestroyerPoints = GameObject.Find("DestroyerPoints");
    }

    private void Update()
    {
        if (transform.position.x < platformDestroyerPoints.transform.position.x)
        {
            //Destroy(gameObject);
            gameObject.SetActive(false);
        }
    }
}

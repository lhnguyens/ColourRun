using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    public GameObject thePlatform;
    public Transform generationPoints;
    private float distanceBetween;
    //private List<Color> colors;

    public float distanceBetweenMin;
    public  float distanceBetweenMax;

    public GameObject[] listOfPlatforms;
    public int platformSelector;
    public float[] platformWidths;

    PlayerController myPlayerController;

    void Start()
    {
        platformWidths = new float[listOfPlatforms.Length];

        for (int i = 0; i < listOfPlatforms.Length; i++)
        {
            platformWidths[i] = listOfPlatforms[i].GetComponent<Transform>().localScale.x;
        }
        myPlayerController = FindObjectOfType<PlayerController>();
        
    }
    
    void Update()
    {
        
        if (transform.position.x < generationPoints.position.x)
        {
            distanceBetween = Random.Range(distanceBetweenMin, distanceBetweenMax);
            platformSelector = Random.Range(0, listOfPlatforms.Length);
            transform.position = new Vector2(transform.position.x + platformWidths[platformSelector] + distanceBetween, transform.position.y);
            GameObject newPlatform = Instantiate(listOfPlatforms[platformSelector], transform.position, transform.rotation);
            newPlatform.GetComponent<SpriteRenderer>().color = myPlayerController.colors[Random.Range(0, myPlayerController.colors.Count)];
        }
    }
}

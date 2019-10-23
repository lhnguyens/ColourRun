using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePlatform : MonoBehaviour
{
    public GameObject[] availablePlatforms;
    public List<GameObject> currentPlatforms;
    private float screenWidthInPoints;

    private void Start()
    {
        float height = 2.0f * Camera.main.orthographicSize;
        screenWidthInPoints = height * Camera.main.aspect;

        StartCoroutine(GeneratorCheck());
    }

    void AddPlatforms(float farthestRoomEndX)
    {
        int randomRoomIndex = Random.Range(0, availablePlatforms.Length);
        GameObject platform = (GameObject)Instantiate(availablePlatforms[randomRoomIndex]);
        float platformWidth = platform.transform.Find("platform_Yellow").localScale.x;
        float platformCenter = farthestRoomEndX + platformWidth * 0.5f;
        platform.transform.position = new Vector3(platformCenter, 0, 0);
        currentPlatforms.Add(platform);
    }

    void GeneratePlatformIfNeeded()
    {
        List<GameObject> platformsToKill = new List<GameObject>();
        bool addPlatforms = true;
        float playerX = transform.position.x;
        float removePlatformX = playerX - screenWidthInPoints;
        float addPlatformX = playerX + screenWidthInPoints;
        float longestPlatformEndX = 0;

        foreach(var platform in currentPlatforms)
        {
            float platformWidth = platform.transform.Find("platform_Yellow").localScale.x;
            float platformStartX = platform.transform.position.x - (platformWidth * 0.5f);
            float platformEndX = platformStartX + platformWidth;

            if (platformStartX > addPlatformX)
            {
                addPlatforms = false;
            }
            if (platformEndX < removePlatformX)
            {
                platformsToKill.Add(platform);
            }

            longestPlatformEndX = Mathf.Max(longestPlatformEndX, platformEndX);

            foreach(var platforms in platformsToKill)
            {
                currentPlatforms.Remove(platforms);
                Destroy(platforms);

            }

            if(addPlatforms)
            {
                AddPlatforms(longestPlatformEndX);
            }
        }

    }
    private IEnumerator GeneratorCheck()
    {
        while (true)
        {
            GeneratePlatformIfNeeded();
            yield return new WaitForSeconds(0.25f);
        }
    }

}

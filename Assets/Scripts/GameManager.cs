using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform platformGenerator;
    private Vector2 platformStartPoint;

    public PlayerController thePlayer;
    private Vector2 playerStartPoint;

    private PlatformDestroyer[] platformList;

    private ScoreManager scoreManager;

    public DeathMenu deathMenu;
    public AudioSource myAudioSource;
    PowerUps powerups;
   
                 
    void Start()
    {
        platformStartPoint = platformGenerator.position;
        playerStartPoint = thePlayer.transform.position;
        scoreManager = FindObjectOfType<ScoreManager>();
        myAudioSource = GetComponent<AudioSource>();
        powerups = FindObjectOfType<PowerUps>();
        //audioPlay = true;

    }

    public void RestartGame()
    {
        scoreManager.scoreIncreasing = false;
        thePlayer.gameObject.SetActive(false);
        deathMenu.gameObject.SetActive(true);
        myAudioSource.Stop();

        
    }

    public void Reset()
    {
        deathMenu.gameObject.SetActive(false);
        platformList = FindObjectsOfType<PlatformDestroyer>();
        for (int i = 0; i < platformList.Length; i++)
        {
            platformList[i].gameObject.SetActive(false);
        }
        thePlayer.transform.position = playerStartPoint;
        platformGenerator.position = platformStartPoint;
        thePlayer.gameObject.SetActive(true);
        scoreManager.scoreCount = 0;
        scoreManager.scoreIncreasing = true;
        myAudioSource.Play();
        //powerups.gameObject.SetActive(true);
    }

   
}

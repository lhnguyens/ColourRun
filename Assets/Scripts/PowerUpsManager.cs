using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpsManager : MonoBehaviour
{
    private bool speedBoost;
    public bool powerUpActive;
    private float powerUpCountDown;

    private PlayerController thePlayer;
    private PlatformGenerator theGenerator;

    private float normalSpeed;


    private void Start()
    {
        thePlayer = FindObjectOfType<PlayerController>();
        theGenerator = FindObjectOfType<PlatformGenerator>(); 
    }
    private void Update()
    {
        if(powerUpActive)
        {
            powerUpCountDown -= Time.deltaTime;

            if(speedBoost)
            {
                thePlayer.speedOfPlayer = normalSpeed * 2.0f;
               
            }

            if(powerUpCountDown <= 0)
            {
                thePlayer.speedOfPlayer = normalSpeed;
                powerUpActive = false;
                
            }
        }
    }


    public void ActivatePowerUp(bool boost, float time)
    {
        speedBoost = boost;
        powerUpCountDown = time;

        normalSpeed = thePlayer.speedOfPlayer;
        powerUpActive = true;

    }
}

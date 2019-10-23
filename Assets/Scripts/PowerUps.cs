using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    public bool speedBoost;
    public float powerUpLength;

    private PowerUpsManager pwM;

    private void Start()
    {
        pwM = FindObjectOfType<PowerUpsManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {

            pwM.ActivatePowerUp(speedBoost, powerUpLength); 

        }
        gameObject.SetActive(false);
    }
}
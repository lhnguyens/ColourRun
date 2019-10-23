using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControl : MonoBehaviour
{

    //SpriteRenderer myPlayerSpriteRenderer;

    //public List<Color> colors;

    //public bool jump = false;
    //public float moveForce = 50f;
    //public float maxSpeed = 10f;
    //public float currentSpeed;
    //public float touchRun;
    //public float jumpSpeed;
    //public float speedOfPlayer = 10f;

    //private Rigidbody2D rb;
    //private float screenWidth;

    //public Transform groundCheck;
    //public bool grounded = false;
    //public float jumpForce = 800f;

    //private void Awake()
    //{
    //    rb = GetComponent<Rigidbody2D>();
    //    screenWidth = Screen.width;
    //    myPlayerSpriteRenderer = GetComponent<SpriteRenderer>();
    //}

    //private void Update()
    //{
    //    Vector2 newVelocity = rb.velocity;
    //    newVelocity.x = speedOfPlayer;
    //    rb.velocity = newVelocity;

    //    grounded = Physics2D.Linecast(transform.position,
    //        groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));


    //    int i = 0;

    //    while (i < Input.touchCount)
    //    {
    //        if (Input.GetTouch(i).position.x < screenWidth / 2)
    //        {
    //            SwitchColor();
    //        }

    //        if (Input.GetTouch(i).phase == TouchPhase.Began && Input.GetTouch(i).position.x > screenWidth * 0.5)
    //        {
    //            jump = true;
    //        }
    //        ++i;
    //    }
    //}
    //private void FixedUpdate()
    //{
    //    if (jump)
    //    {
    //        JumpPlayer();
    //    }
    //}

    //private void JumpPlayer()
    //{
    //    if (grounded)
    //    {
    //        rb.AddForce(new Vector2(0f, jumpForce));
    //        grounded = false;
    //    }
    //    jump = false;
    //}

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.collider.tag == "deathCatcher")
    //    {
    //        GameObject.Find("GameManager").GetComponent<GameManager>().RestartGame();
    //    }
    //}
    //private void OnCollisionStay2D(Collision2D collision)
    //{
    //    if (collision.collider.tag == "deathCatcher")
    //    {
    //        GameObject.Find("GameManager").GetComponent<GameManager>().RestartGame();
    //    }
    //}
    //private void OnCollisionExit2D(Collision2D collision)
    //{
    //    if (collision.collider.tag == "deathCatcher")
    //    {
    //        GameObject.Find("GameManager").GetComponent<GameManager>().RestartGame();
    //    }
    //}

    //void SwitchColor()
    //{
    //    Color newColor = myPlayerSpriteRenderer.color;

    //    while (newColor == myPlayerSpriteRenderer.color)
    //    {
    //        newColor = colors[Random.Range(0, colors.Count)];
    //    }

    //    myPlayerSpriteRenderer.color = newColor;

    //}


}

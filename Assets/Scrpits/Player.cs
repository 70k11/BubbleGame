using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private float playerspeed = 4f;
    public Rigidbody2D rb;
    private float movement = 0f;

    void Update()
    { 
        movement = Input.GetAxisRaw("Horizontal") * playerspeed;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + new Vector2(movement * Time.fixedDeltaTime, 0f));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ball") 
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

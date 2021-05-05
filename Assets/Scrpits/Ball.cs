using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Vector2 StartForce;
    public Rigidbody2D rb;
    public GameObject nextBall; 
     
    void Start()
    {
        rb.AddForce(StartForce, ForceMode2D.Impulse);   
    }

    public void Split()
    {
        if (nextBall != null)
        {
            var ball1 = Instantiate(nextBall, rb.position + Vector2.right / 4f, Quaternion.identity);
            var ball2 = Instantiate(nextBall, rb.position + Vector2.left / 4f, Quaternion.identity);

            ball1.GetComponent<Ball>().StartForce = new Vector2(2f, 5f);
            ball2.GetComponent<Ball>().StartForce = new Vector2(-2f, 5f);
        }
        Destroy(gameObject);
    }
}

using UnityEngine;

public class ChainCollision : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider)
    {
        Chain.IsFired = false;

        if(collider.tag == "Ball")
            collider.GetComponent<Ball>().Split();
    }
}



using UnityEngine;

public class pz : MonoBehaviour
{

    public movement movement;


    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.CompareTag("Obstacle"))
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();

        }
    }
}
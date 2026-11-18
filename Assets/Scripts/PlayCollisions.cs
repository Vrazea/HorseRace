using UnityEngine;

public class PlayCollisions : MonoBehaviour
{
    [SerializeField] private PlayerMovementScript playerMovementScript;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.CompareTag("Obstacle"))
        {
            Debug.Log("touché qqch " + collisionInfo.collider.name);
            playerMovementScript.enabled = false;
        }
        
    }
}

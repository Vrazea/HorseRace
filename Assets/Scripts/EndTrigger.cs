using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    void OnTriggerEnter(Collider collider)
    {
        if(collider.CompareTag("Player"))
        {
            Debug.Log("Le joueur a atteint la ligne d'arrivée");
            gameManager.CompleteLevel();
        }
    }
}

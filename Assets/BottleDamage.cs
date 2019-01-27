using UnityEngine;

public class BottleDamage : MonoBehaviour
{

    public GameUIManager GameUiManager;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameUiManager.RemoveLife();
        }
    }
}

using UnityEngine;

public class WallTrigger : MonoBehaviour
{
    public WallTriggerController WallTriggerController;
    
    private bool inTrigger = false;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            inTrigger = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            inTrigger = false;
        }
    }

    void Update()
    {
        if (inTrigger && Input.GetKeyDown(KeyCode.Space))
        {
            WallTriggerController.Teleport(gameObject.name);
            inTrigger = false;
        }
    }
}

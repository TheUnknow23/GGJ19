using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OilBehaviour : MonoBehaviour
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

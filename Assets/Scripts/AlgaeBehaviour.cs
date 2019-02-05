using UnityEngine;

public class AlgaeBehaviour : MonoBehaviour
{

    public int life = 4;

    void Update()
    {
        if (life == 0)
        {
            FindObjectOfType<AudioManager>().Play("Algae");
            Destroy(gameObject);
        }
    }
}

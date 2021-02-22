using UnityEngine;

public class PlatformScript : MonoBehaviour
{

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject, 1.0f);
        }
    }
}

using UnityEngine;

public class PortalScript : MonoBehaviour
{
    [SerializeField]
    private Transform pointToAppear;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = pointToAppear.position;
        }
    }
}
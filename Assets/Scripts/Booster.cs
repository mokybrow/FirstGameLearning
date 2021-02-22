using UnityEngine;

public class Booster : MonoBehaviour
{
    [SerializeField]
    private float _boostForce;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Rigidbody>().AddForce(transform.up * _boostForce);
        }
    }
}

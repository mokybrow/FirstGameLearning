using UnityEngine;

public class Grenade : MonoBehaviour
{
    public GameObject explosionEffect;


    public float delay = 4f;
    public float radius = 5f;
    public float explosionForce = 600f;

    private float countdown;
    private bool hasExploded = false;

    // Start is called before the first frame update
    void Start()
    {
        countdown = delay;
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0f && !hasExploded)
        {
            Explode();
        }
    }

    private void Explode()
    {

        hasExploded = true;

        Destroy(Instantiate(explosionEffect, transform.position, transform.rotation), 4f);
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);

        foreach (Collider sadObject in colliders)
        {
            Rigidbody rb = sadObject.GetComponent<Rigidbody>();

            if (rb != null)
            {
                rb.AddExplosionForce(explosionForce, transform.position, radius);
            }
        }
        Destroy(gameObject);
    }
}
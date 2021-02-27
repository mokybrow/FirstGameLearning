using UnityEngine;

public class BonusScript : MonoBehaviour
{
    [SerializeField]
    private Animator animator;

    [SerializeField]
    private GameObject electroEffect;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameObject.GetComponent<CapsuleCollider>().enabled = false;
            animator.SetTrigger("PickUp");
            Invoke("ActivateEffect", 1.5f);
            Destroy(gameObject.transform.parent.gameObject, 1.5f);
        }   
    }

    void ActivateEffect()
    {
        GameObject ourEffect = Instantiate(electroEffect, transform.position, Quaternion.identity);
        Destroy(ourEffect, 2f);

    }
}

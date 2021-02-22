using UnityEngine;

public class Switcher : MonoBehaviour
{
    [SerializeField]
    private GameObject _objectToSwitch;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _objectToSwitch.SetActive(!_objectToSwitch.activeSelf);
        }
        
    }
}

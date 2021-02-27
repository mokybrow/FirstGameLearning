using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField]
    private Transform _targetObject;

    private Vector3 _offset;
    // Start is called before the first frame update
    void Start()
    {
        _offset = transform.position - _targetObject.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = _targetObject.position + _offset;
    }
}

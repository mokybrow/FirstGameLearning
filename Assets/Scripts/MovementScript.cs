using UnityEngine;

public class MovementScript : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    [SerializeField]
    private Rigidbody _objectBody;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        float forward = Input.GetAxisRaw("Vertical");
        float right = Input.GetAxisRaw("Horizontal");
        _objectBody.AddForce(new Vector3(right, 0, forward) * _speed * Time.deltaTime);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

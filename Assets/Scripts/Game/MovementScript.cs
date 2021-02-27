using UnityEngine;

public class MovementScript : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    [SerializeField]
    private float _jumpForce;

    [SerializeField]
    private Rigidbody _objectBody;

    private float _jumpRayLength;

    // Start is called before the first frame update
    void Start()
    {
        _jumpRayLength = transform.localScale.y / 2 + 0.3f;
    }

    void FixedUpdate()
    {
        float forward = Input.GetAxisRaw("Vertical");
        float right = Input.GetAxisRaw("Horizontal");
        _objectBody.AddForce(new Vector3(right, 0, forward) * _speed * Time.fixedDeltaTime);

        if (Input.GetKey(KeyCode.Space) && Physics.Raycast(transform.position, Vector3.down, _jumpRayLength))
        {
            _objectBody.AddForce(Vector3.up * _jumpForce);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

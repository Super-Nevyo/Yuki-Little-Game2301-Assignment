using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float jumpForce;
    private Vector2 _direction;
    private Rigidbody _rb;
    
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _rb.linearVelocity = new Vector3(_direction.x * speed, _rb.linearVelocity.y, _direction.y * speed);
        Debug.Log(_rb.linearVelocity);
    }

    public void OnMove(InputValue value)
    {
        _direction = value.Get<Vector2>();
    }

    public void OnJump(InputValue value)
    {
        _rb.AddForce(0,jumpForce,0);
    }
}

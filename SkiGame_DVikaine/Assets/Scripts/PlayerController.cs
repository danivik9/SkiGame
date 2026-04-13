using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{
    private InputAction move;
    [SerializeField] private float rotSpeed = 45, speed = 20;
    void Awake()
    {
        move = InputSystem.actions.FindAction("Player/Move");
        rb = GetComponent<Rigidbody>();
    }
    
    void FixedUpdate()
    {
       rb.AddForce(transform.forward * speed * Time.fixedDeltaTime);
       Vector2 moveInput = move.ReadValue<Vector2>();
       transform.Rotate(0, -moveInput.x * rotSpeed * Time.fixedDeltaTime, 0);
    }
}

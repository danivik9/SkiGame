using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerController : MonoBehaviour
{
    private InputAction move;

    void Awake()
    {
        move = InputSystem.actions.FindAction("Player/Move");
    }
    
    void Update()
    {
       Vector2 moveInput = move.ReadValue<Vector2>();
       Debug.Log("x: " + moveInput.x + "y:" + moveInput.y);
    }
}

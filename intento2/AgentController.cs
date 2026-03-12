using UnityEngine;
using UnityEngine.InputSystem;

public class AgentController : MonoBehaviour

{
    InputAction moveAction;
    public Vector2 moveValue;
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
    }

    // Update is called once per frame
    void Update()
    {
        moveValue = moveAction.ReadValue<Vector2>();
    }
}

using UnityEngine;
using UnityEngine.InputSystem;

public class BreakOut : MonoBehaviour
{
    public InputActionReference action;

    void Start()
    {
        action.action.Enable();

        action.action.performed += (ctx) =>
        {
            if (transform.position.y < 0.1f)
            {
                transform.position = new Vector3(0, 25, 0);
            }
            else
            {
                transform.position = new Vector3(0, 0, 0);
            }
        };
    }
}

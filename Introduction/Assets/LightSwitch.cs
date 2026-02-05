using UnityEngine;
using UnityEngine.InputSystem;

public class LightSwitch : MonoBehaviour
{
    public Light light;
    public InputActionReference action;

    void Start()
    {
        light = GetComponent<Light>();
        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            if (light.color == Color.blue)
            {
                light.color = Color.white;
            } else
            {
                light.color = Color.blue;
            }
        };
    }
}

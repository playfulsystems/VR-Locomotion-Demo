using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class ToggleRayOnPress : MonoBehaviour
{
    public InputActionReference joystickPress;

    // Start is called before the first frame update
    private void OnEnable()
    {
        joystickPress.action.started += ToggleRayOn;
        joystickPress.action.canceled += ToggleRayOff;
    }

    private void ToggleRayOn(InputAction.CallbackContext obj)
    {
        GetComponent<XRInteractorLineVisual>().enabled = true;
    }

    private void ToggleRayOff(InputAction.CallbackContext obj)
    {
        GetComponent<XRInteractorLineVisual>().enabled = false;
    }
}

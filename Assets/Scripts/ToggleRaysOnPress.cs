using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class ToggleRaysOnPress : MonoBehaviour
{
    public InputActionReference joystickPress;
    public GameObject teleportController;
    public GameObject rayGrabController;

    // Start is called before the first frame update
    private void OnEnable()
    {
        joystickPress.action.started += ToggleRayOn;
        joystickPress.action.canceled += ToggleRayOff;
    }

    private void ToggleRayOn(InputAction.CallbackContext obj)
    {
        teleportController.GetComponent<XRInteractorLineVisual>().enabled = true;
        rayGrabController.GetComponent<XRInteractorLineVisual>().enabled = false;
    }

    private void ToggleRayOff(InputAction.CallbackContext obj)
    {
        teleportController.GetComponent<XRInteractorLineVisual>().enabled = false;
        rayGrabController.GetComponent<XRInteractorLineVisual>().enabled = true;
    }
}

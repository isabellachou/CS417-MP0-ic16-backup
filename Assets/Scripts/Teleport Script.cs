using UnityEngine;
using UnityEngine.InputSystem;

public class TeleportScript : MonoBehaviour
{
    public InputActionReference action; // button to teleport
    public Transform externalViewPoint; // my PlaneExternal

    private Vector3 roomPosition;
    private Quaternion roomRotation;
    private bool isExternal = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // save starting room position and rotation
        roomPosition = transform.position;
        roomRotation = transform.rotation;

        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            ToggleTeleport();
        };
    }

    void ToggleTeleport()
    {
        isExternal = !isExternal;

        if (isExternal)
        {
            transform.position = externalViewPoint.position;
            transform.rotation = externalViewPoint.rotation;
        }
        else
        {
            transform.position = roomPosition;
            transform.rotation = roomRotation;
        }
    }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }
}

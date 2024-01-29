using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BreakOut : MonoBehaviour
{
    public Transform transform;
    public InputActionReference teleportAction;
    private bool teleported;

    // Start is called before the first frame update
    void Start()
    {
        teleported = false;


        teleportAction.action.Enable();

        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (teleportAction.action.triggered) {
            if (!teleported) {
                transform.position = new Vector3(100.0f, 0.0f, 0.0f);
            } else {
                transform.position = new Vector3(0.0f, 0.0f, 0.0f);
            }

            teleported = !teleported;
        }
    }
}

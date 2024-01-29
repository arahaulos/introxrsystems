using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Quit : MonoBehaviour
{

    public InputActionReference quitAction;

    // Start is called before the first frame update
    void Start()
    {
        quitAction.action.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        if (quitAction.action.triggered) {
            #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
            #else
                Application.Quit();
            #endif
        }
    }
}

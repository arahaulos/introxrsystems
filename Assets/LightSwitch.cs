using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LightSwitch : MonoBehaviour
{
    public Light light;
    public InputActionReference lightColorSwitch;
    private bool colorSwitched;

    // Start is called before the first frame update
    void Start()
    {
        colorSwitched = false;

        lightColorSwitch.action.Enable();

        light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (lightColorSwitch.action.triggered) {
             if (!colorSwitched) {
                light.color = new Color(1.0f, 0, 0);
             } else {
                light.color = new Color(1.0f, 1.0f, 1.0f);
             }

             colorSwitched = !colorSwitched;
        }
    }
}

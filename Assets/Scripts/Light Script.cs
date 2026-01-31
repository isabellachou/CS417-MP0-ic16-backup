using UnityEngine;
using UnityEngine.InputSystem;

public class LightScript : MonoBehaviour
{
    public Light sceneLight;
    public InputActionReference action;

    private Color oriColor;
    private Color diffColor = new Color(1f, 0f, 0.711823f);
    private bool isSwitched = false;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sceneLight = GetComponent<Light>();

        // store the original light color
        oriColor = sceneLight.color;

        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            isSwitched = !isSwitched;
            sceneLight.color = isSwitched ? diffColor : oriColor;
        };
    }

    // // Update is called once per frame
    // void Update()
    // {

    // }
}

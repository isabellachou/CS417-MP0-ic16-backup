using UnityEngine;

public class RotateScript : MonoBehaviour
{
    public float rotationSpeed = 26f;

    // // Start is called once before the first execution of Update after the MonoBehaviour is created
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    void Update()
    {
        // rotate planet aroun its y-axis
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}

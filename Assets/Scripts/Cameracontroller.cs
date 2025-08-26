using UnityEngine;
using UnityEngine.InputSystem;

public class Cameracontroller : MonoBehaviour
{
    [SerializeField] Transform m_Camera;
    InputAction InputAction;

    public float mousex;
    public float mousey;
    public float sensibility;
    public float Yrotation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        InputAction = InputSystem.actions.FindAction("Look");
    }

    // Update is called once per frame
    void Update()
    {
        Movercamera();
    }

    public void Movercamera()
    {
        mousey = InputAction.ReadValue<Vector2>().x * sensibility * Time.deltaTime;


        Yrotation += mousey;
        m_Camera.localRotation = Quaternion.Euler(0, Yrotation, 0);
    }
}

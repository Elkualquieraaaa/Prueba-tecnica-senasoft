using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.InputSystem;

public class Playercontroller : MonoBehaviour
{
    CharacterController characterController;
    InputAction action;
    Transform position;
    [SerializeField] Animator controller; 
    float moveX;
    float moveZ;
    public float velocity;
    Vector3 iny;
    public float gravity = -9.8f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        characterController = GetComponent<CharacterController>();  
        action = InputSystem.actions.FindAction("Move");
        position = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        moveZ = action.ReadValue<Vector2>().y * velocity;
        moveX = action.ReadValue<Vector2>().x * velocity;

        Debug.Log(moveX);

        iny.y = gravity; 

        if (moveZ != 0 || moveX != 0)
        {
            controller.SetBool("Ismove", true);
        }
        else
        {
            controller.SetBool("Ismove", false);
        }

        characterController.Move(transform.forward * moveZ * Time.deltaTime+ iny+ transform.right*moveX * Time.deltaTime);

        if (action != null )
        {
            Debug.Log("Se encontro");
        }
    }
}

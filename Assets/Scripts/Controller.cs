using UnityEngine;
using UnityEngine.InputSystem;

public class Controller : MonoBehaviour
{
    public float moveSpeed;
    public float rotationSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool isUpHeld = Keyboard.current.upArrowKey.isPressed;
        bool isDownHeld = Keyboard.current.downArrowKey.isPressed;
        bool isLeftHeld = Keyboard.current.leftArrowKey.isPressed;


        if (isUpHeld)
        {
            transform.position += transform.up * moveSpeed * Time.deltaTime;
        }

        if (isDownHeld)
        {
            transform.position -= transform.up * moveSpeed * Time.deltaTime;
        }


        if (isLeftHeld)
        {
            transform.eulerAngles += transform.forward * rotationSpeed * Time.deltaTime;
        }




    }
}

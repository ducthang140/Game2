using UnityEngine;
using UnityEngine.InputSystem;

public class LRControl : MonoBehaviour
{
    public Rigidbody2D MyRigidBody;
    public float ControlStrength;
    public Logic LogicPass;
    public bool SSS = true;

    // Mobile button states
    private bool leftPressed = false;
    private bool rightPressed = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        LogicPass = GameObject.FindGameObjectWithTag("LogicTag").GetComponent<Logic>();
    }

    // Update is called once per frame
    void Update()
    {
        // Keyboard input
        bool keyboardLeft = Keyboard.current != null &&
                            Keyboard.current.leftArrowKey.isPressed;

        bool keyboardRight = Keyboard.current != null &&
                             Keyboard.current.rightArrowKey.isPressed;

        // Combine keyboard and mobile input
        bool moveLeft = keyboardLeft || leftPressed;
        bool moveRight = keyboardRight || rightPressed;

        if (moveLeft && moveRight)
        {
            MyRigidBody.linearVelocity = Vector2.zero;
        }
        else if (moveLeft && SSS)
        {
            MyRigidBody.linearVelocity = Vector2.left * ControlStrength;
        }
        else if (moveRight && SSS)
        {
            MyRigidBody.linearVelocity = Vector2.right * ControlStrength;
        }
        else
        {
            MyRigidBody.linearVelocity = Vector2.zero;
        }
    }

    // LEFT BUTTON

    public void LeftButtonDown()
    {
        leftPressed = true;
    }

    public void LeftButtonUp()
    {
        leftPressed = false;
    }

    // RIGHT BUTTON

    public void RightButtonDown()
    {
        rightPressed = true;
    }

    public void RightButtonUp()
    {
        rightPressed = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            LogicPass.GameOver();
            SSS = false;
        }
    }
}
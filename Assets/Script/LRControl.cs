using UnityEngine;
using UnityEngine.InputSystem;

public class LRControl : MonoBehaviour
{
    public Rigidbody2D MyRigidBody;
    public float ControlStrength;
    public Logic LogicPass;
    public bool SSS = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        LogicPass = GameObject.FindGameObjectWithTag("LogicTag").GetComponent<Logic>();
    }

    // Update is called once per frame
    void Update()
    {
        bool leftPressed = Keyboard.current.leftArrowKey.isPressed;
        bool rightPressed = Keyboard.current.rightArrowKey.isPressed;

        if (leftPressed && rightPressed)
        {
            MyRigidBody.linearVelocity = Vector2.zero;
        }
        else if (leftPressed && SSS)
        {
            MyRigidBody.linearVelocity = Vector2.left * ControlStrength;
        }
        else if (rightPressed && SSS)
        {
            MyRigidBody.linearVelocity = Vector2.right * ControlStrength;
        }
        else
        {
            MyRigidBody.linearVelocity = Vector2.zero;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Obstacle"))
        {
            LogicPass.GameOver();
            SSS = false;
        }
    }
}
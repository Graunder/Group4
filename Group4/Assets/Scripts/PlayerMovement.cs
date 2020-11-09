using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController2D controller;
    public float speed = 5f;
    public Joystick joystick;

    private float moveHorizontal = 0f;
    private bool jump;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveHorizontal = joystick.Horizontal * speed;

        //Uncomment to enable "wasd" movement for testing in editor
        moveHorizontal = Input.GetAxisRaw("Horizontal") * speed;
    }

    public void Jump() {
        jump = true;
    }

    private void FixedUpdate() {
        controller.Move(moveHorizontal * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}

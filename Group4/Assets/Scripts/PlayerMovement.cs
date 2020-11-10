using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float fallForce = 400f;

    public CharacterController2D controller;
    public float speed = 5f;
    public Joystick joystick;

    private float moveHorizontal = 0f;
    private bool jump;
    private Rigidbody2D playerRigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveHorizontal = joystick.Horizontal * speed;

        //Uncomment to enable "wasd" movement for testing in editor
        //moveHorizontal = Input.GetAxisRaw("Horizontal") * speed;
    }

    public void Awake() {
        playerRigidbody2D = GetComponent<Rigidbody2D>();
    }

    public void Jump() {
        jump = true;
    }

    private void FixedUpdate() {
        controller.Move(moveHorizontal * Time.deltaTime, false, jump);
        jump = false;

        if (playerRigidbody2D.velocity.y < -0.1) {
            playerRigidbody2D.AddForce(new Vector2(0f, -fallForce));
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour {

    [SerializeField]
    public int lives = 3; //PascalCase or camelCase

    [SerializeField]
    private string name = "Mario";

    [SerializeField]
    private float jumpHeight = 5, speed = 5;

    private bool hasKey;

    //[SerializeField]
    private bool isOnGround;

    private Rigidbody2D rigidbody2DInstance;
    private float horizontalInput;
	// Use this for initialization
	void Start () {
        //we have to initialize our rigidbody variable!
        rigidbody2DInstance = GetComponent<Rigidbody2D>();

        

        rigidbody2DInstance.gravityScale = 5;
	}
	
	// Update is called once per frame
	private void Update () {
        //don't use translate because we're using physics
        //if (Input.GetAxis("Horizontal"))
        //{
        //    MoveLeft();
        //}

        ////Move();
        //if (Input.GetButton())
        //{
        //    MoveRight();
        //}
        GetInput();
        Move();
        

    }

    private void GetInput()
    {
        horizontalInput = Input.GetAxis("Horizontal");
    }

    private void Move()
    {
        rigidbody2DInstance.velocity = new Vector2(horizontalInput, 0);
    }

    
}

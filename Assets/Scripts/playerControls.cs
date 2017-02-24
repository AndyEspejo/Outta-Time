using UnityEngine;
using System.Collections;

public class playerControls : MonoBehaviour {
    //Initial Vars
    public Rigidbody2D playerRB;

    public float speed;
    public float jumpSpeed;
    
    public bool grounded;


	// Use this for initialization
	void Start () {
        playerRB = this.gameObject.GetComponent<Rigidbody2D>();
	}
    
	// Update is called once per frame
	void Update () {
        
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W) && grounded){
            playerRB.AddForce(Vector2.up * jumpSpeed);
        }

        if (Input.GetKey(KeyCode.D)){
            Vector3 move = new Vector2(speed, 0);
            this.gameObject.transform.position += move;
        }

        if (Input.GetKey(KeyCode.A)){
            Vector3 move = new Vector2(speed, 0);
            this.gameObject.transform.position -= move;
        }
    }
    private void OnCollisionExit2D(Collision2D collision){
        if (collision.gameObject.name == "platform" && collision.contacts[0].normal.y > 0){
            grounded = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.name == "platform" && collision.contacts[0].normal.y > 0)
        {
            grounded = true;
        }
    }

}

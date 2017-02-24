using UnityEngine;
using System.Collections;

public class enemyBehavior : MonoBehaviour {
    public float walkSpeed;

    private float leftBound;
    private float rightBound;
    private bool right;

    



	// Use this for initialization
	void Start () {
        leftBound = this.transform.position.x - 1;
        rightBound = this.transform.position.x + 1;

	}

    // Update is called once per frame
    void Update(){
        move();
    }

    //From http://answers.unity3d.com/questions/690884/how-to-move-an-object-along-x-axis-between-two-poi.html
    void move() {
        if (right){
            transform.Translate(Vector2.right * walkSpeed * Time.deltaTime);
        }else{
            transform.Translate(-Vector2.right * walkSpeed * Time.deltaTime);
        }

        if(transform.position.x >= rightBound) { right = false; }
        if (transform.position.x <= leftBound) { right = true; }
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.name == "playerChar" && collision.contacts[0].normal.y == -1){
            Destroy(this.gameObject);
        }else if(collision.gameObject.name == "playerChar"){
            Destroy(collision.gameObject);
        }
    }


}

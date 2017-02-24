using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class endLevelController : MonoBehaviour {
    private bool playerAtDoor;
    public string nextLevel;

	// Use this for initialization
	void Start () {
        playerAtDoor = false;
	}

    //Will check if player has high enough score (50% of gems) as they press Up to let them through to the next level
    void Update () {
	    if (Input.GetKeyDown(KeyCode.W) && playerAtDoor && scoreManager.checkScore() ){
            SceneManager.LoadScene(nextLevel);
        }
	}

    void OnTriggerEnter2D(Collider2D collision){
        if(collision.name == "playerChar"){
            playerAtDoor = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision){
        if (collision.name == "playerChar")
        {
            playerAtDoor = false;
        }
    }


}

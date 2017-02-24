using UnityEngine;
using System.Collections;

public class gemCollect : MonoBehaviour
{
    public float points;
    timeManager TimeManager;
    void Start() {
       TimeManager = GameObject.Find("playerChar").GetComponent<timeManager>();
    }
    //Do Nothing unless player collides
    void OnTriggerEnter2D(Collider2D collision){
        if (collision.GetComponent<playerControls>() == null) { return; }
        Destroy(gameObject);
        scoreManager.addScore();
        TimeManager.addTime(points);
    }
}

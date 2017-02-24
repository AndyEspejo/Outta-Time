using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeManager : MonoBehaviour {

    public float timeLeft;
  
    // Update is called once per frame
    void Update () {
        decreaseTime();
	}

    void decreaseTime() {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0) {
            Destroy(GameObject.Find("playerChar"));
        }
    }

    public void addTime(float seconds) {
        timeLeft += seconds;
    }
}

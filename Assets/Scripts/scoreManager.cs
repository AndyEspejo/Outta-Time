using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour {

    public static int score;
    public static int gemsAtStart;
    Text text;
	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
        score = 0;
        gemsAtStart = GameObject.FindGameObjectsWithTag("Gems").Length;
    }
	
	// Update is called once per frame
	void Update () {
        text.text = "" + score + "/" + gemsAtStart;   
	}

    public static void addScore(){
        score += 1;
    }

    public static void reset(){
        score = 0;
    }

    //Checks that you have at least half of the gems collected;
    public static bool checkScore(){
        if ((float)score / gemsAtStart >= .5){
            return true;
        }else{
            return false;
        }
    }

}

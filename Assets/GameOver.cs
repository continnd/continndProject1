using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

    public GameObject ui;
    private UnityEngine.UI.Text text;

	void Update() {
        text = ui.GetComponent<UnityEngine.UI.Text>();
	    if (GameObject.Find("StickyBall") == null) {
            text.text = "Game Over";
        }
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop : MonoBehaviour {

    bool stopFlag = false;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if (!stopFlag) {
                Time.timeScale = 0;
                stopFlag = !stopFlag;
            }
            else {
                Time.timeScale = 1;
                stopFlag = !stopFlag;
            }

        }
    }
}

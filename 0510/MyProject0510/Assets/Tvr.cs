using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tvr : MonoBehaviour {

    // Use this for initialization
    void Start() {
        //GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Mouse0)) {
            GetComponent<Renderer>().enabled = !GetComponent<Renderer>().enabled;

        }
    }
}

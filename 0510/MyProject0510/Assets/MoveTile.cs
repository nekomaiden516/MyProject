using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTile : MonoBehaviour {

    bool onFlg = false;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (onFlg) {
            gameObject.transform.position += new Vector3(0, 0.025f, 0);
        }

    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") {
            onFlg = true;
        }
    }
}

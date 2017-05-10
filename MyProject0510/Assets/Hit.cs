using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour {

    bool hitFlg = false;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (hitFlg) {
            Debug.Log("hit");
        }
        hitFlg = false;

    }

    /*private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") {
            Destroy(other.gameObject);

        }
    }*/

    private void OnTriggerStay(Collider other) {
        if (other.gameObject.tag == "Player") {
            hitFlg = true;
        }
    }
}

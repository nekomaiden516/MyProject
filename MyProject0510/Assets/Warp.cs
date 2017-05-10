using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour {

    public GameObject wPoint;
    Vector3 wPointV;

    // Use this for initialization
    void Start() {
        wPointV = wPoint.transform.position;
    }

    // Update is called once per frame
    void Update() {

    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") {
            other.gameObject.transform.position = wPointV + new Vector3(0, 1, 0);
        }
    }
}

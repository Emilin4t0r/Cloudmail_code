using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeederTilt : MonoBehaviour {
    public float tiltMultiplier;
    float tiltAmt;
    public GameObject parent;
    Speeder3D speeder;
    private void Start() {
        speeder = parent.GetComponent<Speeder3D>();
    }
    void FixedUpdate() {       
        transform.position = parent.transform.position;

        tiltAmt = speeder.Xcoord * tiltMultiplier;
        float x = parent.transform.localEulerAngles.x;
        float y = parent.transform.localEulerAngles.y;
        transform.localEulerAngles = new Vector3(x, y, -tiltAmt);     

        if (speeder.inDockArea && tiltAmt != 0) {
            tiltAmt = 0;
        }
    }
}

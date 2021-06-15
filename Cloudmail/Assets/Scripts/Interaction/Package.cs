using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Package : MonoBehaviour {

    public bool onSpeeder = false;

    void Update() {
        if (InteractRay.instance.IsLookingAt(gameObject)) {
            if (Input.GetKeyDown(KeyCode.E)) {
                LoadOnSpeeder();
            }
        }
    }

    void LoadOnSpeeder() {
        onSpeeder = true;
        QuestManager.instance.LoadPackageOnSpdr(gameObject);
        print("Loaded package onto speeder!");
    }
}

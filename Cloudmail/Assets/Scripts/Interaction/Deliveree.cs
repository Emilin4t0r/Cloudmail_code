using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deliveree : MonoBehaviour {

    GameObject parentShip;

    private void Start() {
        parentShip = transform.parent.gameObject;
    }

    void Update() {
        if (InteractRay.instance.IsLookingAt(gameObject)) {
            if (Input.GetKeyDown(KeyCode.E)) {
                Deliver();
            }
        }
    }

    void Deliver() {
        GameObject pkg = (GameObject)QuestManager.instance.relations[parentShip];
        if (pkg.GetComponent<Package>().onSpeeder) {
            Destroy(pkg.gameObject);
            QuestManager.instance.relations.Remove(parentShip);
            QuestManager.instance.activeQuests--;
            print("Package delivered successfully!");
            //Make ship move away and destroy it after player far away enough from it
        } else {
            print("Package not found on speeder!");
        }
    }
}

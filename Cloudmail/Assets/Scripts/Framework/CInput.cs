using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

namespace CustomInput {
    public class CInput : MonoBehaviour {

        public static KeyCode forward;
        public static KeyCode backward;
        public static KeyCode left;
        public static KeyCode right;
        public static KeyCode jump;
        public static KeyCode boost;
        public static KeyCode interact;
        public static KeyCode enter;
        public static KeyCode select;

        private void Awake() {
            forward = KeyCode.W;
            backward = KeyCode.S;
            left = KeyCode.A;
            right = KeyCode.D;
            jump = KeyCode.Space;
            boost = KeyCode.LeftShift;
            interact = KeyCode.E;
            enter = KeyCode.F;
            select = KeyCode.Mouse0;
        }

        public static bool KeyDown(KeyCode key) {
            if (Input.GetKeyDown(key)) {
                return true;
            }
            return false;
        }
        public static bool KeyUp(KeyCode key) {
            if (Input.GetKeyUp(key)) {
                return true;
            }
            return false;
        }
        public static bool HoldKey(KeyCode key) {
            if (Input.GetKey(key)) {
                return true;
            }
            return false;
        }


    }
}

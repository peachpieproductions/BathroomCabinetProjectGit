using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestrictRotation : MonoBehaviour {



    private void Update() {
        var rot = transform.eulerAngles;
        if (rot.x > 180) rot.x -= 360;
        if (rot.y > 180) rot.y -= 360;
        if (rot.x < -55) rot.x = 55;
        if (rot.x > 20) rot.x = 20;
        if (rot.y > 90) rot.y = 90;
        if (rot.y < -90) rot.y = -90;
        transform.eulerAngles = rot;
    }



}

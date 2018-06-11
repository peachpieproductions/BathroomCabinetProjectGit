using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour {

    public bool altCounterTop;
    public bool altFaucet;
    public bool altSideCab;
    public bool altSinkCab;
    public bool altUpperCab;

    public Transform camOrigin;
    public List<GameObject> set1;
    public List<GameObject> set2;
    public List<Toggle> toggles = new List<Toggle>();

    private void Update() {

        //inputs
        if (Input.GetMouseButton(0)) {
            camOrigin.Rotate(-Input.GetAxis("Mouse Y") * 1.5f, -Input.GetAxis("Mouse X") * 1.5f, 0,Space.World);
            camOrigin.eulerAngles = new Vector3(camOrigin.eulerAngles.x, camOrigin.eulerAngles.y, 0);
        }
        if (Input.GetMouseButton(1)) {
            Camera.main.fieldOfView += -Input.GetAxis("Mouse Y");
        }

        //get toggles
        altCounterTop = toggles[0].isOn;
        altFaucet = toggles[1].isOn;
        altSideCab = toggles[2].isOn;
        altSinkCab = toggles[3].isOn;
        altUpperCab = toggles[4].isOn;

        //Counter Top
        if (altCounterTop) {
            set1[0].gameObject.SetActive(false);
            set2[0].gameObject.SetActive(true);
        }
        else {
            set1[0].gameObject.SetActive(true);
            set2[0].gameObject.SetActive(false);
        }

        //Faucet
        if (altFaucet) {
            set1[1].gameObject.SetActive(false);
            set2[1].gameObject.SetActive(true);
        }
        else {
            set1[1].gameObject.SetActive(true);
            set2[1].gameObject.SetActive(false);
        }

        //Side Cab
        if (altSideCab) {
            set1[2].gameObject.SetActive(false);
            set2[2].gameObject.SetActive(true);
        }
        else {
            set1[2].gameObject.SetActive(true);
            set2[2].gameObject.SetActive(false);
        }

        //Sink Cab
        if (altSinkCab) {
            set1[3].gameObject.SetActive(false);
            set2[3].gameObject.SetActive(true);
        }
        else {
            set1[3].gameObject.SetActive(true);
            set2[3].gameObject.SetActive(false);
        }

        //Upper Cab
        if (altUpperCab) {
            set1[4].gameObject.SetActive(false);
            set2[4].gameObject.SetActive(true);
        }
        else {
            set1[4].gameObject.SetActive(true);
            set2[4].gameObject.SetActive(false);
        }
    }


}

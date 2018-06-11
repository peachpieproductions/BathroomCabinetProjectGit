using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour {

    public Transform set1;
    public Transform set2;
    public bool altCounterTop;
    public bool altFaucet;
    public bool altSideCab;
    public bool altSinkCab;
    public bool altUpperCab;

    public List<Toggle> toggles = new List<Toggle>();

    private void Start() {
        foreach (Toggle t in FindObjectsOfType<Toggle>()) toggles.Add(t);
    }

    private void Update() {
        altCounterTop = toggles[4].isOn;
        altFaucet = toggles[3].isOn;
        altSideCab = toggles[2].isOn;
        altSinkCab = toggles[1].isOn;
        altUpperCab = toggles[0].isOn;

        //Counter Top
        if (altCounterTop) {
            set1.GetChild(0).gameObject.SetActive(false);
            set2.GetChild(0).gameObject.SetActive(true);
        }
        else {
            set1.GetChild(0).gameObject.SetActive(true);
            set2.GetChild(0).gameObject.SetActive(false);
        }

        //Faucet
        if (altFaucet) {
            set1.GetChild(1).gameObject.SetActive(false);
            set2.GetChild(1).gameObject.SetActive(true);
        }
        else {
            set1.GetChild(1).gameObject.SetActive(true);
            set2.GetChild(1).gameObject.SetActive(false);
        }

        //Side Cab
        if (altSideCab) {
            set1.GetChild(2).gameObject.SetActive(false);
            set2.GetChild(2).gameObject.SetActive(true);
        }
        else {
            set1.GetChild(2).gameObject.SetActive(true);
            set2.GetChild(2).gameObject.SetActive(false);
        }

        //Sink Cab
        if (altSinkCab) {
            set1.GetChild(3).gameObject.SetActive(false);
            set2.GetChild(3).gameObject.SetActive(true);
        }
        else {
            set1.GetChild(3).gameObject.SetActive(true);
            set2.GetChild(3).gameObject.SetActive(false);
        }

        //Upper Cab
        if (altUpperCab) {
            set1.GetChild(4).gameObject.SetActive(false);
            set2.GetChild(4).gameObject.SetActive(true);
        }
        else {
            set1.GetChild(4).gameObject.SetActive(true);
            set2.GetChild(4).gameObject.SetActive(false);
        }
    }


}

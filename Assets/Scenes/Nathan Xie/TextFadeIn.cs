using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextFadeIn : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textField;
    [SerializeField] private Player playerObject;
    Boolean activateText;
    void Update() {
        updateText();
    }

    private void updateText(){
        if(activateText) {
            textField.alpha = (float) Math.Log(8f / Vector3.Magnitude(playerObject.transform.position - transform.position));
        }
    }
    void OnTriggerEnter(Collider other) {
        activateText = true;
    }

    void OnTriggerExit(Collider other) {
        activateText = false; 
        textField.alpha = 0;  
    }
}
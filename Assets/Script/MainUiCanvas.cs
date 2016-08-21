using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MainUiCanvas : MonoBehaviour {

    Text messageText;
    Text enableTestText;
    void Awake()
    {
        messageText = transform.FindChild("MessageText").GetComponent<Text>();
        enableTestText = transform.FindChild("EnableTestText").GetComponent<Text>();
        enableTestText.enabled = false;
    }


    public void MessageStart()
    {
        print("MessageStart");
        messageText.text = "hello";
        enableTestText.enabled = true;

    }




}

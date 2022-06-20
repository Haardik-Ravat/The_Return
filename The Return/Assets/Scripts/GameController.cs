using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Player player;
    public InputField textEntryField;
    public Text logText;
    public Text curText;


    [TextArea]
    public string introText;

    // Start is called before the first frame update
    void Start()
    {
        logText.text = introText;
        DisplayLocation();
        textEntryField.ActivateInputField();

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void DisplayLocation() {

        string desc = player.currentLocation.Description+"\n";
        desc += player.currentLocation.GetConnections();
        curText.text = desc;
    
    }
}

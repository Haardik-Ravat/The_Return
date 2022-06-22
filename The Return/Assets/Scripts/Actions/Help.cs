using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Actions/Help")]
public class Help : Action
{

    public override void Respond(GameController controller, string verb)
    {
        controller.curText.text = "Type a verb followed by a noun(e.g. \"go north\")";
        controller.curText.text += "\nAllowed Verbs:\nGo, Examine, Get, Use, Inventory, TalkTo, Say, Help";

    }
}

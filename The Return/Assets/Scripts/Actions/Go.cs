using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Actions/Go")]
public class Go : Action
{
    public override void Respond(GameController controller, string verb)
    {
        if (controller.player.ChangeLocaion(controller, verb))
        {
            controller.DisplayLocation();

        }
        else {
            controller.curText.text = "You can't go that way!";
        }


    }
}

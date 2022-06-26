using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Actions/Inventory")]
public class Inventory : Action
{
    public override void Respond(GameController controller, string noun)
    {
        if (controller.player.Inventory.Count == 0)
        {
            controller.curText.text = "You have nothing";
            return;
        }
        string ress = "You have ";
        bool first = true;
        foreach (item it in controller.player.Inventory)
        
        {


            if(first)
            ress += " a " + it.itemName;
            else
                ress += "and a " + it.itemName;

            first = false;
        }
        controller.curText.text = ress;
    }
}

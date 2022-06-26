using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Actions/Get")]
public class Get : Action
{
    public override void Respond(GameController controller, string noun)
    {
        foreach (item it in controller.player.currentLocation.items)
        {
            if (it.ItemEnabled && it.itemName == noun)
            {
                if (it.playerCanTake)

                {
                    controller.player.Inventory.Add(it);
                    controller.player.currentLocation.items.Remove(it);
                    controller.curText.text = "You take the" + noun;
                    return;
                }

            }
        }
        controller.curText.text = "You can't get that!";
    }

 
}


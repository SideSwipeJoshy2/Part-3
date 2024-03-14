using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using TMPro.SpriteAssetUtilities;

public class CharacterControl : MonoBehaviour
{
    public TextMeshProUGUI tmp;
    public static Villager SelectedVillager { get; private set; }
    public static void SetSelectedVillager(Villager villager)
    {
        if (SelectedVillager != null)
        {
            SelectedVillager.Selected(false);
        }
        SelectedVillager = villager;
        SelectedVillager.Selected(true);
        
    }

    private void Update()
    {
        if (SelectedVillager != null)
        {
            tmp.text = "selected: " + SelectedVillager.canOpen().ToString();
        }
        else
        {
            tmp.text = "selected: n/a";
        }
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModuleGoodUI : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("Icon")]    public Image Pull;
[UnityEngine.Serialization.FormerlySerializedAs("NumText")]    public Text TieCart;

    public void Partly(Sprite icon, int num = 0)
    {
        Pull.sprite = icon;
        if (num == 0) {
            TieCart.gameObject.SetActive(false);
        }
        else
        {
            TieCart.text = "+" + num.ToString();
            TieCart.gameObject.SetActive(true);
        }
    }
}

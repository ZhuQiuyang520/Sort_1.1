using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModuleLast : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("Desc")]    public Text Shop;
    public void Jade(double RewardNumber)
    {
        Shop.text = RewardNumber.ToString("f2");
    }
}

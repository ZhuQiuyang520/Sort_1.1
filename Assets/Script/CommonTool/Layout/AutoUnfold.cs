using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public enum TargetType
{
    Scene,
    UGUI
}
public enum LayoutType
{
    Sprite_First_Weight,
    Sprite_First_Height,
    Screen_First_Weight,
    Screen_First_Height,
    Bottom,
    Top,
    Left,
    Right
}
public enum RunTime
{
    Awake,
    Start,
    None
}
public class AutoUnfold : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("Target_Type")]    public TargetType Reason_Care;
[UnityEngine.Serialization.FormerlySerializedAs("Layout_Type")]    public LayoutType Unfold_Care;
[UnityEngine.Serialization.FormerlySerializedAs("Run_Time")]    public RunTime Hem_Show;
[UnityEngine.Serialization.FormerlySerializedAs("Layout_Number")]    public float Unfold_Stress;
    private void Awake()
    {
        if (Hem_Show == RunTime.Awake)
        {
            EmployFiring();
        }
    }
    private void Start()
    {
        if (Hem_Show == RunTime.Start)
        {
            EmployFiring();
        }
    }

    public void EmployFiring()
    {
        if (Unfold_Care == LayoutType.Sprite_First_Weight)
        {
            if (Reason_Care == TargetType.UGUI)
            {

                float scale = Screen.width / Unfold_Stress;
                //GetComponent<RectTransform>().sizeDelta = new Vector2(Screen.width, Screen.width / w * h);
                transform.localScale = new Vector3(scale, scale, scale);
            }
        }
        if (Unfold_Care == LayoutType.Screen_First_Weight)
        {
            if (Reason_Care == TargetType.Scene)
            {
                float scale = RimSystemVole.RimIndicate().WedRotaryUtter() / Unfold_Stress;
                transform.localScale = transform.localScale * scale;
            }
        }
        
        if (Unfold_Care == LayoutType.Bottom)
        {
            if (Reason_Care == TargetType.Scene)
            {
                float screen_bottom_y = RimSystemVole.RimIndicate().WedRotaryUseful() / -2;
                screen_bottom_y += (Unfold_Stress + (RimSystemVole.RimIndicate().WedCobaltLook(gameObject).y / 2f));
                transform.position = new Vector3(transform.position.x, screen_bottom_y, transform.position.y);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

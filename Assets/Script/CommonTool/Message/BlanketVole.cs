using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 消息传递的参数
/// </summary>
public class BlanketVole
{
    /*
     *  1.创建独立的消息传递数据结构，而不使用object，是为了避免数据传递时的类型强转
     *  2.制作过程中遇到实际需要传递的数据类型，在这里定义即可
     *  3.实际项目中需要传递参数的类型其实并没有很多种，这种方式基本可以满足需求
     */
    public bool GiantHeed;
    public bool GiantHeed2;
    public int GiantDot;
    public int GiantDot2;
    public int GiantDot3;
    public float GiantHinge;
    public float GiantHinge2;
    public double GiantTwelve;
    public double GiantTwelve2;
    public string GiantSyntax;
    public string GiantSyntax2;
    public GameObject GiantBoneCompel;
    public GameObject GiantBoneCompel2;
    public GameObject GiantBoneCompel3;
    public GameObject GiantBoneCompel4;
    public Transform GiantIntensely;
    public List<string> GiantSyntaxHard;
    public List<Vector2> GiantNor2Hard;
    public List<int> GiantDotHard;
    public System.Action AbilityGermHunt;
    public Vector2 Bis2_1;
    public Vector2 Bis2_2;
    public BlanketVole()
    {
    }
    public BlanketVole(Vector2 v2_1)
    {
        Bis2_1 = v2_1;
    }
    public BlanketVole(Vector2 v2_1, Vector2 v2_2)
    {
        Bis2_1 = v2_1;
        Bis2_2 = v2_2;
    }
    /// <summary>
    /// 创建一个带bool类型的数据
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public BlanketVole(bool value)
    {
        GiantHeed = value;
    }
    public BlanketVole(bool value, bool value2)
    {
        GiantHeed = value;
        GiantHeed2 = value2;
    }
    /// <summary>
    /// 创建一个带int类型的数据
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public BlanketVole(int value)
    {
        GiantDot = value;
    }
    public BlanketVole(int value, int value2)
    {
        GiantDot = value;
        GiantDot2 = value2;
    }
    public BlanketVole(int value, int value2, int value3)
    {
        GiantDot = value;
        GiantDot2 = value2;
        GiantDot3 = value3;
    }
    public BlanketVole(List<int> value,List<Vector2> value2)
    {
        GiantDotHard = value;
        GiantNor2Hard = value2;
    }
    /// <summary>
    /// 创建一个带float类型的数据
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public BlanketVole(float value)
    {
        GiantHinge = value;
    }
    public BlanketVole(float value,float value2)
    {
        GiantHinge = value;
        GiantHinge = value2;
    }
    /// <summary>
    /// 创建一个带double类型的数据
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public BlanketVole(double value)
    {
        GiantTwelve = value;
    }
    public BlanketVole(double value, double value2)
    {
        GiantTwelve = value;
        GiantTwelve = value2;
    }
    /// <summary>
    /// 创建一个带string类型的数据
    /// </summary>
    /// <param name="value"></param>
    public BlanketVole(string value)
    {
        GiantSyntax = value;
    }
    /// <summary>
    /// 创建两个带string类型的数据
    /// </summary>
    /// <param name="value1"></param>
    /// <param name="value2"></param>
    public BlanketVole(string value1,string value2)
    {
        GiantSyntax = value1;
        GiantSyntax2 = value2;
    }
    public BlanketVole(GameObject value1)
    {
        GiantBoneCompel = value1;
    }

    public BlanketVole(Transform transform)
    {
        GiantIntensely = transform;
    }
}


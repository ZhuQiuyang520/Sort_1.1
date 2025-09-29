using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System;
public class MillXenonSister : DeedSingleton<MillXenonSister>
{
    public string version = "1.2";
    public string BoneLuce= FluHealWar.instance.BoneLuce;
    //channel
#if UNITY_IOS
    private string Subsidy= "AppStore";
#elif UNITY_ANDROID
    private string Channel = "GooglePlay";
#else
    private string Channel = "GooglePlay";
#endif


    private void OnApplicationPause(bool pause)
    {
        MillXenonSister.RimIndicate().WoodBoneSpecimen();
    }
    
    public Text Ware;

    protected override void Awake()
    {
        base.Awake();
        
        version = Application.version;
        StartCoroutine(nameof(HomeBlanket));
    }
    IEnumerator HomeBlanket()
    {
        while (true)
        {
            yield return new WaitForSeconds(120f);
            MillXenonSister.RimIndicate().WoodBoneSpecimen();
        }
    }
    private void Start()
    {
        if (TownVoleBenefit.RimDot("event_day") != DateTime.Now.Day && TownVoleBenefit.RimSyntax("user_servers_id").Length != 0)
        {
            TownVoleBenefit.YamDot("event_day", DateTime.Now.Day);
        }
    }
    public void MoatAxDateXenon(string event_id)
    {
        MoatXenon(event_id);
    }
    public void WoodBoneSpecimen(List<string> valueList = null)
    {
        if (TownVoleBenefit.RimTwelve(CRamble.Dy_RevolutionCareGene) == 0)
        {
            TownVoleBenefit.YamTwelve(CRamble.Dy_RevolutionCareGene, TownVoleBenefit.RimDot(CRamble.Dy_GoldGene));
        }
        if (TownVoleBenefit.RimTwelve(CRamble.Dy_RevolutionHyper) == 0)
        {
            TownVoleBenefit.YamTwelve(CRamble.Dy_RevolutionHyper, TownVoleBenefit.RimTwelve(CRamble.Dy_Hyper));
        }
        if (valueList == null)
        {
            valueList = new List<string>() {

                TownVoleBenefit.RimDot(CRamble.Dy_GoldGene).ToString(),
                TownVoleBenefit.RimTwelve(CRamble.Dy_Hyper).ToString(),
                TownVoleBenefit.RimDot(CRamble.Dy_RevolutionCareGene).ToString(),
                TownVoleBenefit.RimSyntax(CRamble.Dy_RevolutionHyper),
                TownVoleBenefit.RimDot(CRamble.Dy_SoloistPumpMental).ToString(),
                //TownVoleBenefit.GetInt(SlotConfig.sv_SlotSpinCount).ToString()
            };
        }
        
        if (TownVoleBenefit.RimSyntax(CRamble.Dy_EnjoyWanderNo) == null)
        {
            return;
        }
        WWWForm wwwForm = new WWWForm();
        wwwForm.AddField("gameCode", BoneLuce);
        wwwForm.AddField("userId", TownVoleBenefit.RimSyntax(CRamble.Dy_EnjoyWanderNo));

        wwwForm.AddField("gameVersion", version);

        wwwForm.AddField("channel", Subsidy);

        for (int i = 0; i < valueList.Count; i++)
        {
            wwwForm.AddField("resource" + (i + 1), valueList[i]);
        }
        StartCoroutine(MoatMill(FluHealWar.instance.RoarMar + "/api/client/game_progress", wwwForm,
        (error) =>
        {
            Debug.Log(error);
        },
        (message) =>
        {
            Debug.Log(message);
        }));
    }
    public void MoatXenon(string event_id, string p1 = null, string p2 = null, string p3 = null)
    {
        if (Ware != null)
        {
            if (int.Parse(event_id) < 9100 && int.Parse(event_id) >= 9000)
            {
                if (p1 == null)
                {
                    p1 = "";
                }
                Ware.text += "\n" + DateTime.Now.ToString() + "id:" + event_id + "  p1:" + p1;
            }
        }
        if (TownVoleBenefit.RimSyntax(CRamble.Dy_EnjoyWanderNo) == null)
        {
            FluHealWar.instance.Adapt();
            return;
        }
        WWWForm wwwForm = new WWWForm();
        wwwForm.AddField("gameCode", BoneLuce);
        wwwForm.AddField("userId", TownVoleBenefit.RimSyntax(CRamble.Dy_EnjoyWanderNo));
        //Debug.Log("userId:" + TownVoleBenefit.GetString(CRamble.sv_LocalServerId));
        wwwForm.AddField("version", version);
        //Debug.Log("version:" + version);
        wwwForm.AddField("channel", Subsidy);
        //Debug.Log("channel:" + channal);
        wwwForm.AddField("operateId", event_id);
        Debug.Log("operateId:" + event_id);


        if (p1 != null)
        {
            wwwForm.AddField("params1", p1);
        }
        if (p2 != null)
        {
            wwwForm.AddField("params2", p2);
        }
        if (p3 != null)
        {
            wwwForm.AddField("params3", p3);
        }
        StartCoroutine(MoatMill(FluHealWar.instance.RoarMar + "/api/client/log", wwwForm,
        (error) =>
        {
            Debug.Log(error);
        },
        (message) =>
        {
            Debug.Log(message);
        }));
    }
    IEnumerator MoatMill(string _url, WWWForm wwwForm, Action<string> fail, Action<string> success)
    {
        //Debug.Log(SerializeDictionaryToJsonString(dic));
        using UnityWebRequest request = UnityWebRequest.Post(_url, wwwForm);
        yield return request.SendWebRequest();
        if (request.isNetworkError || request.isNetworkError)
        {
            fail(request.error);
            RagDarling();
        }
        else
        {
            success(request.downloadHandler.text);
            RagDarling();
        }
    }
    private void RagDarling()
    {
        StopCoroutine(nameof(MoatMill));
    }


}
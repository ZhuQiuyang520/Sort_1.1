using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlaxBenefit : MonoBehaviour
{
    public static FlaxBenefit instance;

    private bool Prone= false;

    private void Awake()
    {
        instance = this;
        Application.targetFrameRate = 60;
    }

    //切前后台也需要检测屏蔽 防止游戏中途更改手机状态
    private void OnApplicationFocus(bool focusStatus)
    {
        if (focusStatus)
            VerbalRend.SleeperStiltCreep();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void SealJade()
    {
        bool isNewPlayer = !PlayerPrefs.HasKey(CRamble.Dy_NoMapSpiral + "Bool") || TownVoleBenefit.RimHeed(CRamble.Dy_NoMapSpiral);
        CommonJadeBenefit.Instance.JadeCommonVole(isNewPlayer);
        if (isNewPlayer)
        {
            // 新用户
            TownVoleBenefit.YamHeed(CRamble.Dy_NoMapSpiral, false);
            BoneVoleBenefit.RimIndicate().RibCare(FluHealWar.instance.BoneVole.initgamedata.initial_coin);
            PlayerPrefs.SetInt(VoleBenefit.TownDarnOral, FluHealWar.instance.BoneVole.initgamedata.add_bottles_nums);
            PlayerPrefs.SetInt(VoleBenefit.TownInfectOral, FluHealWar.instance.BoneVole.initgamedata.Hint_nums);
            PlayerPrefs.SetInt(VoleBenefit.TownStockingOral, FluHealWar.instance.BoneVole.initgamedata.withdrawn_nums);
            PlayerPrefs.SetInt(VoleBenefit.TownValid, 1);
            PlayerPrefs.SetInt(VoleBenefit.TownSquirrelValid, 3);
            PlayerPrefs.SetInt(VoleBenefit.TownValidEver, 1);
            PlayerPrefs.SetInt(VoleBenefit.TownDiffusely, 1);
            PlayerPrefs.SetString(VoleBenefit.BranchWeightValid, "");
            //获取瓶子和颜色的初始皮肤  数字为表里的colorGroup字段
            PlayerPrefs.SetInt(VoleBenefit.TownSadToss, 1);
            //存储的数据为colorGroup字段
            VoleBenefit.YamHard(VoleBenefit.TownLopBelowToss, 0, 1);
            PlayerPrefs.SetInt(VoleBenefit.TownDarnToss, 1);
            VoleBenefit.YamHard(VoleBenefit.TownLopDarnToss, 0, 1);
            //商店引导是否执行 0未执行 1执行过
            PlayerPrefs.SetInt(VoleBenefit.TownToErieBand, 0);
            PlayerPrefs.SetInt(VoleBenefit.TownDiffusely, 1);
            PlayerPrefs.SetInt(VoleBenefit.TownRealm, 1);
            PlayerPrefs.SetInt(VoleBenefit.TownOrgan, 1);
            RealmWar.RimIndicate().BodeIt(RealmCare.SceneMusic.bgm);
            //RealmWar.GetInstance().setBgmCloseOneTime();

            BoneBenefit.RimIndicate().NoTitle = true;
            BoneBenefit.RimIndicate().NoRealm = true;
            BoneBenefit.RimIndicate().NoOrgan = true;
        }
        else
        {
            //读取是否开启震动设置
            if (PlayerPrefs.GetInt(VoleBenefit.TownDiffusely) == 1)
            {
                BoneBenefit.RimIndicate().NoTitle = true;
            }
            else
            {
                BoneBenefit.RimIndicate().NoTitle = false;
            }
            RealmWar.RimIndicate().BodeIt(RealmCare.SceneMusic.bgm);
            if (PlayerPrefs.GetInt(VoleBenefit.TownRealm) == 1)
            {
                BoneBenefit.RimIndicate().NoRealm = true;
                RealmWar.RimIndicate().IllFewExploitLagShow();
            }
            else
            {
                BoneBenefit.RimIndicate().NoRealm = false;
                RealmWar.RimIndicate().IllFewBoardLagShow();
            }

            if (PlayerPrefs.GetInt(VoleBenefit.TownOrgan) == 1)
            {
                BoneBenefit.RimIndicate().NoOrgan = true;
            }
            else
            {
                BoneBenefit.RimIndicate().NoOrgan = false;
            }
        }

        //RealmWar.GetInstance().PlayBg(RealmCare.SceneMusic.bgm);
        BoneBenefit.RimIndicate().PikeSadToss();
        if (PlayerPrefs.GetInt(VoleBenefit.TownValid) == 1)
        {
            UIBenefit.RimIndicate().WrapUILight(nameof(BoneTowel));
        }
        else
        {
            UIBenefit.RimIndicate().WrapUILight(nameof(BuckTowel));
        }

        BoneVoleBenefit.RimIndicate().JadeBoneVole();

        Prone = true;

    }

}

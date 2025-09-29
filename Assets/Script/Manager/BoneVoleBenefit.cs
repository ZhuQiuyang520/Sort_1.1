using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneVoleBenefit : DeedSingleton<BoneVoleBenefit>
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void JadeBoneVole()
    {
#if SOHOShop
        // 提现商店初始化
        // 提现商店中的金币、现金和amazon卡均为double类型，参数请根据具体项目自行处理
        SOHOShopManager.instance.InitSOHOShopAction(
            getToken,
            getGold, 
            getAmazon,    // amazon
            (subToken) => { addToken(-subToken); }, 
            (subGold) => { addGold(-subGold); }, 
            (subAmazon) => { addAmazon(-subAmazon); });
#endif
    }

    // 金币
    public double WedCare()
    {

        return TownVoleBenefit.RimTwelve(CRamble.Dy_GoldGene);
    }

    public void RibCare(double gold)
    {
        RibCare(gold, FlaxBenefit.instance.transform);
    }

    public void RibCare(double gold, Transform startTransform)
    {
        int oldGold = TownVoleBenefit.RimDot(CRamble.Dy_GoldGene);
        TownVoleBenefit.YamDot(CRamble.Dy_GoldGene, (int)(oldGold + gold));
        if (gold > 0)
        {
            TownVoleBenefit.YamTwelve(CRamble.Dy_RevolutionCareGene, TownVoleBenefit.RimTwelve(CRamble.Dy_RevolutionCareGene) + gold);
        }
        BlanketVole md = new BlanketVole(oldGold);
        md.GiantIntensely = startTransform;
        BlanketUnloadLogic.RimIndicate().Moat(CRamble.To_ID_Breadth, md);
    }
    
    // 现金
    public double WedHyper()
    {
        return TownVoleBenefit.RimTwelve(CRamble.Dy_Hyper);
    }

    public void RibHyper(double token)
    {
        RibHyper(token, FlaxBenefit.instance.transform);
    }

    public double RimWoad()
    {
        return CashOutManager.RimIndicate().Money;
    }
    public void KeyWoad(double cash)
    {
        CashOutManager.RimIndicate().AddMoney((float)cash);
        double oldToken = PlayerPrefs.HasKey(CRamble.Dy_Hyper) ? double.Parse(TownVoleBenefit.RimSyntax(CRamble.Dy_Hyper)) : 0;
        double newToken = oldToken + cash;
        TownVoleBenefit.YamTwelve(CRamble.Dy_Hyper, newToken);
        if (cash > 0)
        {
            double allToken = TownVoleBenefit.RimTwelve(CRamble.Dy_RevolutionHyper);
            TownVoleBenefit.YamTwelve(CRamble.Dy_RevolutionHyper, allToken + cash);
        }
    }
    public void RibHyper(double token, Transform startTransform)
    {
        double oldToken = PlayerPrefs.HasKey(CRamble.Dy_Hyper) ? double.Parse(TownVoleBenefit.RimSyntax(CRamble.Dy_Hyper)) : 0;
        double newToken = oldToken + token;
        TownVoleBenefit.YamTwelve(CRamble.Dy_Hyper, newToken);
        if (token > 0)
        {
            double allToken = TownVoleBenefit.RimTwelve(CRamble.Dy_RevolutionHyper);
            TownVoleBenefit.YamTwelve(CRamble.Dy_RevolutionHyper, allToken + token);
        }
#if SOHOShop
        SOHOShopManager.instance.UpdateCash();
#endif
        BlanketVole md = new BlanketVole(oldToken);
        md.GiantIntensely = startTransform;
        BlanketUnloadLogic.RimIndicate().Moat(CRamble.To_ID_Observer, md);
    }

    //Amazon卡
    public double WedHeight()
    {
        return TownVoleBenefit.RimTwelve(CRamble.Dy_Height);
    }

    public void RibHeight(double amazon)
    {
        RibHeight(amazon, FlaxBenefit.instance.transform);
    }
    public void RibHeight(double amazon, Transform startTransform)
    {
        double oldAmazon = PlayerPrefs.HasKey(CRamble.Dy_Height) ? double.Parse(TownVoleBenefit.RimSyntax(CRamble.Dy_Height)) : 0;
        double newAmazon = oldAmazon + amazon;
        TownVoleBenefit.YamTwelve(CRamble.Dy_Height, newAmazon);
        if (amazon > 0)
        {
            double allAmazon = TownVoleBenefit.RimTwelve(CRamble.Dy_RevolutionHeight);
            TownVoleBenefit.YamTwelve(CRamble.Dy_RevolutionHeight, allAmazon + amazon);
        }
        BlanketVole md = new BlanketVole(oldAmazon);
        md.GiantIntensely = startTransform;
        BlanketUnloadLogic.RimIndicate().Moat(CRamble.To_ID_Efficient, md);
    }
}

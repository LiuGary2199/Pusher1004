using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadeBulkUncover : MailPerformer<LadeBulkUncover>
{
    // Start is called before the first frame update
    void Start()
    {
    }

    public void PassLadeBulk()
    {
        PassJobBulk();

    }


    private void PassJobBulk()
    {
        if (MoreBulkUncover.TowSmooth(CShield.Dy_MyPassBulk) != "done")
        {
            // 新用户 初始化数据
            MoreBulkUncover.GunSmooth(CShield.Dy_MyPassBulk, "done");
            // 新手引导
            MoreBulkUncover.GunSmooth(CShield.Dy_Narrow_Ask_From_Deter, "new");
            MoreBulkUncover.GunSmooth(CShield.Dy_Relax_Levy_Lid_777, "new");
            MoreBulkUncover.GunSmooth(CShield.Dy_SenseMuch, "new");
            MoreBulkUncover.GunSmooth(CShield.Dy_Relax_Levy_Lid_Summer, "new");
            MoreBulkUncover.GunSmooth(CShield.Dy_Total_Dry_Its, "new");
            MoreBulkUncover.GunSmooth(CShield.Dy_Relax_Sink_out, "new");
            MoreBulkUncover.GunSmooth(CShield.Raw_Mine_Solo_Ox, "new");
            MoreBulkUncover.GunSmooth(CShield.Dy_Relax_Then_again, "new");
            

            
            //收集物初始化
            MoreBulkUncover.GunWok(GemsType.Blue.ToString(), 0);
            MoreBulkUncover.GunWok(GemsType.Blue + "All", 0);
            MoreBulkUncover.GunWok(GemsType.Yellow.ToString(), 0);
            MoreBulkUncover.GunWok(GemsType.Yellow + "All", 0);
            MoreBulkUncover.GunWok(GemsType.Silver.ToString(), 0);
            MoreBulkUncover.GunWok(GemsType.Silver + "All", 0);
            MoreBulkUncover.GunWok(GemsType.GoldBar.ToString(), 0);
            MoreBulkUncover.GunWok(GemsType.GoldBar + "All", 0);
            
            // 余额初始化
            MoreBulkUncover.GunMakeup(CShield.Dy_Dust, 0);
            MoreBulkUncover.GunMakeup(CShield.Dy_RelativelyDust, 0);
            MoreBulkUncover.GunMakeup(CShield.Dy_RimeView, 0);
            MoreBulkUncover.GunMakeup(CShield.Dy_RelativelyRimeView, 0);
            MoreBulkUncover.GunMakeup(CShield.Dy_Coyote, 0);
            MoreBulkUncover.GunMakeup(CShield.Dy_RelativelyCoyote, 0);
            MoreBulkUncover.GunWok(CShield.Dy_Chest_Half_Ice, SapScanTip.instance.LadeBulk.base_config.new_user_ball_count);
            MoreBulkUncover.GunWok(CShield.Dy_RelativelyFast, 30);
            
            MoreBulkUncover.GunMakeup(CShield.Dy_Detail_Tycoon_Snout, 1);
            
        }

        // 
        List<GemsDataItem> CapBulkPeal= SapScanTip.instance.LadeBulk.Gem_Reward_list;
        foreach (GemsDataItem item in CapBulkPeal)
        {
            string gemType = item.gem_type;
            int gemMax = item.gem_limit;
            MoreBulkUncover.GunWok(gemType + "Max", gemMax);
        }
    }

    // 金币
    public double TowRime()
    {
        return MoreBulkUncover.TowMakeup(CShield.Dy_RimeView);
    }

    public double TowRelativelyRimeView()
    {
        return MoreBulkUncover.TowMakeup(CShield.Dy_RelativelyRimeView);
    }

    public void SkyRime(double gold)
    {
        SkyRime(gold, CropUncover.Instance.transform);
    }

    public void SkyRime(double gold, Transform startTransform)
    {
        double oldGold = MoreBulkUncover.TowMakeup(CShield.Dy_RimeView);
        MoreBulkUncover.GunMakeup(CShield.Dy_RimeView, oldGold + gold);
        if (gold > 0)
        {
            MoreBulkUncover.GunMakeup(CShield.Dy_RelativelyRimeView,
                MoreBulkUncover.TowMakeup(CShield.Dy_RelativelyRimeView) + gold);
        }

        // FanwiseBulk md = new FanwiseBulk(oldGold);
        // md.valueTransform = startTransform;
        // FanwiseEnergyHatch.GetInstance().Send(CShield.mg_ui_addgold, md);
    }

    // 现金
    public double TowDust()
    {
       // return MoreBulkUncover.GetDouble(CShield.sv_Cash);
        return CashOutManager.GetInstance().Money;
    }
    
    public double TowRelativelyDust()
    {
        return MoreBulkUncover.TowMakeup(CShield.Dy_RelativelyDust);
    }

    public void SkyDust(double cash)
    {
        //AddCash(cash, CropUncover.Instance.transform);
        CashOutManager.GetInstance().AddMoney((float)cash);
    }

    public void SkyDust(double cash, Transform startTransform)
    {
        double oldCash = MoreBulkUncover.TowMakeup(CShield.Dy_Dust);
        double newCash = oldCash + cash;
        MoreBulkUncover.GunMakeup(CShield.Dy_Dust, newCash);
        if (cash > 0)
        {
            double allCash = MoreBulkUncover.TowMakeup(CShield.Dy_RelativelyDust);
            MoreBulkUncover.GunMakeup(CShield.Dy_RelativelyDust, allCash + cash);
        }
//#if SOHOShop
//        SOHOShopManager.instance.UpdateCash();
//#endif
        // FanwiseBulk md = new FanwiseBulk(oldCash);
        // md.valueTransform = startTransform;
        // FanwiseEnergyHatch.GetInstance().Send(CShield.mg_ui_addtoken, md);
    }

    //Amazon卡
    public double TowCoyote()
    {
        return MoreBulkUncover.TowMakeup(CShield.Dy_Coyote);
    }
    
    public double TowRelativelyCoyote()
    {
        return MoreBulkUncover.TowMakeup(CShield.Dy_RelativelyCoyote);
    }

    public void SkyCoyote(double amazon)
    {
        SkyCoyote(amazon, CropUncover.Instance.transform);
    }

    public void SkyCoyote(double amazon, Transform startTransform)
    {
        double oldAmazon = PlayerPrefs.HasKey(CShield.Dy_Coyote)
            ? double.Parse(MoreBulkUncover.TowSmooth(CShield.Dy_Coyote))
            : 0;
        double newAmazon = oldAmazon + amazon;
        MoreBulkUncover.GunMakeup(CShield.Dy_Coyote, newAmazon);
        if (amazon > 0)
        {
            double allAmazon = MoreBulkUncover.TowMakeup(CShield.Dy_RelativelyCoyote);
            MoreBulkUncover.GunMakeup(CShield.Dy_RelativelyCoyote, allAmazon + amazon);
        }

        FanwiseBulk md = new FanwiseBulk(oldAmazon);
        md.MinorResonance = startTransform;
        FanwiseEnergyHatch.GetInstance().Cany(CShield.Be_Ox_Horseback, md);
    }


    public int TowFast()
    {
        return MoreBulkUncover.TowWok(CShield.Dy_Chest_Half_Ice);
    }

    public void SkyFast(int num)
    {
        // MoreBulkUncover.SetInt(CShield.sv_steel_ball_num, MoreBulkUncover.GetInt(CShield.sv_steel_ball_num) + num);
        MoreBulkUncover.GunWok(CShield.Dy_RelativelyFast, MoreBulkUncover.TowWok(CShield.Dy_RelativelyFast) + num);
    }


    public void SkyRaw(GemsType gemsType)
    {
        MoreBulkUncover.GunWok(gemsType.ToString(), MoreBulkUncover.TowWok(gemsType.ToString()) + 1);
        MoreBulkUncover.GunWok(gemsType + "All", MoreBulkUncover.TowWok(gemsType + "All") + 1);
        if (MoreBulkUncover.TowWok(gemsType.ToString()) == MoreBulkUncover.TowWok(gemsType + "Max"))
        {
            VerifyGroupUncover.Instance.PearDisposeCrowdPlank();
        }

    }
}
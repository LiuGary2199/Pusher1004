/*
*
*   功能：整个UI框架的核心，用户程序通过调用本类，来调用本框架的大多数功能。  
*           功能1：关于入“栈”与出“栈”的UI窗体4个状态的定义逻辑
*                 入栈状态：
*                     Freeze();   （上一个UI窗体）冻结
*                     Display();  （本UI窗体）显示
*                 出栈状态： 
*                     Hiding();    (本UI窗体) 隐藏
*                     Redisplay(); (上一个UI窗体) 重新显示
*          功能2：增加“非栈”缓存集合。 
* 
* 
* ***/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// UI窗体管理器脚本（框架核心脚本）
/// 主要负责UI窗体的加载、缓存、以及对于“UI窗体基类”的各种生命周期的操作（显示、隐藏、重新显示、冻结）。
/// </summary>
public class UIManager : MonoBehaviour
{
    [HideInInspector]
[UnityEngine.Serialization.FormerlySerializedAs("MainCanvas")]    public Canvas CropStripe;
    private static UIManager _Variance= null;
    //ui窗体预设路径（参数1，窗体预设名称，2，表示窗体预设路径）
    private Dictionary<string, string> _LopStainOrbit;
    //缓存所有的ui窗体
    private Dictionary<string, GoldUIStain> _LopALLUIStain;
    //栈结构标识当前ui窗体的集合
    private Stack<GoldUIStain> _StaExtinctUIStain;
    //当前显示的ui窗体
    private Dictionary<string, GoldUIStain> _LopExtinctPearUIStain;
    //临时关闭窗口
    private List<string> _MoatUIStain;
    //ui根节点
    private Transform _YetStripeStimulate= null;
    //全屏幕显示的节点
    private Transform _YetVerify= null;
    //固定显示的节点
    private Transform _YetMagma= null;
    //弹出节点
    private Transform _YetEatNo= null;
    //ui特效节点
    private Transform _Ear= null;
    //ui管理脚本的节点
    private Transform _YetUIAverage= null;
    [HideInInspector]
[UnityEngine.Serialization.FormerlySerializedAs("PanelName")]    public string PlankHail;
    List<string> PlankHailPeal;
    public List<string> MoatUIStain    {
        get
        {
            return _MoatUIStain;
        }
    }
    //得到实例
    public static UIManager GetInstance()
    {
        if (_Variance == null)
        {
            _Variance = new GameObject("_UIManager").AddComponent<UIManager>();
            
        }
        return _Variance;
    }
    //初始化核心数据，加载ui窗体路径到集合中
    public void Awake()
    {
        PlankHailPeal = new List<string>();
        //字段初始化
        _LopALLUIStain = new Dictionary<string, GoldUIStain>();
        _LopExtinctPearUIStain = new Dictionary<string, GoldUIStain>();
        _MoatUIStain = new List<string>();
        _LopStainOrbit = new Dictionary<string, string>();
        _StaExtinctUIStain = new Stack<GoldUIStain>();
        //初始化加载（根ui窗体）canvas预设
        PassTendStripeFibrous();
        //得到UI根节点，全屏节点，固定节点，弹出节点
        //Debug.Log("this.gameobject" + this.gameObject.name);
        _YetStripeStimulate = GameObject.FindGameObjectWithTag(EndLondon.SYS_TAG_CANVAS).transform;
        _YetVerify = GrazeInform.FlaxTheChickList(_YetStripeStimulate.gameObject,EndLondon.SYS_NORMAL_NODE);
        _YetMagma = GrazeInform.FlaxTheChickList(_YetStripeStimulate.gameObject, EndLondon.SYS_FIXED_NODE);
        _YetEatNo = GrazeInform.FlaxTheChickList(_YetStripeStimulate.gameObject,EndLondon.SYS_POPUP_NODE);
        _Ear = GrazeInform.FlaxTheChickList(_YetStripeStimulate.gameObject, EndLondon.SYS_TOP_NODE);
        _YetUIAverage = GrazeInform.FlaxTheChickList(_YetStripeStimulate.gameObject,EndLondon.SYS_SCRIPTMANAGER_NODE);
        //把本脚本作为“根ui窗体”的子节点
        GrazeInform.SkyChickListNoOnwardList(_YetUIAverage, this.gameObject.transform);
        //根UI窗体在场景转换的时候，不允许销毁
        DontDestroyOnLoad(_YetStripeStimulate);
        //初始化ui窗体预设路径数据
        PassUIStainOrbitBulk();
    }
    private void SkyPlank(string name)
    {
        if (!PlankHailPeal.Contains(name))
        {
            PlankHailPeal.Add(name);
            PlankHail = name;
        }
    }
    private void GemPlank(string name)
    {
        if (PlankHailPeal.Contains(name))
        {
            PlankHailPeal.Remove(name);
        }
        if (PlankHailPeal.Count == 0)
        {
            PlankHail = "";
        }
        else
        {
            PlankHail = PlankHailPeal[0];
        }
    }
    //初始化加载（根ui窗体）canvas预设
    private void PassTendStripeFibrous()
    {
        CropStripe = FrameworkTip.GetInstance().RaceSmoke(EndLondon.SYS_PATH_CANVAS, false).GetComponent<Canvas>();
    }
    /// <summary>
    /// 显示ui窗体
    /// 功能：1根据ui窗体的名称，加载到所有ui窗体缓存集合中
    /// 2,根据不同的ui窗体的显示模式，分别做不同的加载处理
    /// </summary>
    /// <param name="uiFormName">ui窗体预设的名称</param>
    public GameObject PearUIStain(string uiFormName)
    {
        //参数的检查
        if (string.IsNullOrEmpty(uiFormName)) return null;
        //根据ui窗体的名称，把加载到所有ui窗体缓存集合中
        //ui窗体的基类
        GoldUIStain baseUIForms = RaceStainNoALLUIStainClean(uiFormName);
        if (baseUIForms == null) return null;

        SkyPlank(uiFormName);
        
        //判断是否清空“栈”结构体集合
        if (baseUIForms.ExtinctUIOnce.MySouthCounterChange)
        {
            SouthShrubCause();
        }
        //根据不同的ui窗体的显示模式，分别做不同的加载处理
        switch (baseUIForms.ExtinctUIOnce.UIForm_ShowMode)
        {
            case UIFormShowMode.Normal:
                BrawlUIStainTonal(uiFormName);
                break;
            case UIFormShowMode.ReverseChange:
                SourUIStain(uiFormName);
                break;
            case UIFormShowMode.HideOther:
                BrawlUITraderNoTonalAfarOther(uiFormName);
                break;
            case UIFormShowMode.Wait:
                BrawlUIStainTonalMoatFolly(uiFormName);
                break;
            default:
                break;
        }
        return baseUIForms.gameObject;
    }

    /// <summary>
    /// 关闭或返回上一个ui窗体（关闭当前ui窗体）
    /// </summary>
    /// <param name="strUIFormsName"></param>
    public void FollyNoHanderUIStain(string strUIFormsName)
    {
        GemPlank(strUIFormsName);
        //Debug.Log("关闭窗体的名字是" + strUIFormsName);
        //ui窗体的基类
        GoldUIStain baseUIForms = null;
        if (string.IsNullOrEmpty(strUIFormsName)) return;
        _LopALLUIStain.TryGetValue(strUIFormsName,out baseUIForms);
        //所有窗体缓存中没有记录，则直接返回
        if (baseUIForms == null) return;
        //判断不同的窗体显示模式，分别处理
        switch (baseUIForms.ExtinctUIOnce.UIForm_ShowMode)
        {
            case UIFormShowMode.Normal:
                DareUIStainTonal(strUIFormsName);
                break;
            
            case UIFormShowMode.ReverseChange:
                EatUIStain();
                break;
            case UIFormShowMode.HideOther:
                DareUIStainPermTonalBigPearTroop(strUIFormsName);
                break;
            case UIFormShowMode.Wait:
                DareUIStainTonal(strUIFormsName);
                break;
            default:
                break;
        }
        
    }
    /// <summary>
    /// 显示下一个弹窗如果有的话
    /// </summary>
    public void PearPageEatNo()
    {
        if (_MoatUIStain.Count > 0)
        {
            PearUIStain(_MoatUIStain[0]);
            _MoatUIStain.RemoveAt(0);
        }
    }

    /// <summary>
    /// 清空当前等待中的UI
    /// </summary>
    public void SouthMoatUIStain()
    {
        if (_MoatUIStain.Count > 0)
        {
            _MoatUIStain = new List<string>();
        }
    }
     /// <summary>
     /// 根据UI窗体的名称，加载到“所有UI窗体”缓存集合中
      /// 功能： 检查“所有UI窗体”集合中，是否已经加载过，否则才加载。
      /// </summary>
      /// <param name="uiFormsName">UI窗体（预设）的名称</param>
      /// <returns></returns>
    private GoldUIStain RaceStainNoALLUIStainClean(string uiFormName)
    {
        //加载的返回ui窗体基类
        GoldUIStain baseUIResult = null;
        _LopALLUIStain.TryGetValue(uiFormName, out baseUIResult);
        if (baseUIResult == null)
        {
            //加载指定名称ui窗体
            baseUIResult = RaceUIPeak(uiFormName);

        }
        return baseUIResult;
    }
    /// <summary>
    /// 加载指定名称的“UI窗体”
    /// 功能：
    ///    1：根据“UI窗体名称”，加载预设克隆体。
    ///    2：根据不同预设克隆体中带的脚本中不同的“位置信息”，加载到“根窗体”下不同的节点。
    ///    3：隐藏刚创建的UI克隆体。
    ///    4：把克隆体，加入到“所有UI窗体”（缓存）集合中。
    /// 
    /// </summary>
    /// <param name="uiFormName">UI窗体名称</param>
    private GoldUIStain RaceUIPeak(string uiFormName)
    {
        string strUIFormPaths = null;
        GameObject goCloneUIPrefabs = null;
        GoldUIStain baseUIForm = null;
        //根据ui窗体名称，得到对应的加载路径
        _LopStainOrbit.TryGetValue(uiFormName, out strUIFormPaths);
        if (!string.IsNullOrEmpty(strUIFormPaths))
        {
            //加载预制体
           goCloneUIPrefabs= FrameworkTip.GetInstance().RaceSmoke(strUIFormPaths, false);
        }
        //设置ui克隆体的父节点（根据克隆体中带的脚本中不同的信息位置信息）
        if(_YetStripeStimulate!=null && goCloneUIPrefabs != null)
        {
            baseUIForm = goCloneUIPrefabs.GetComponent<GoldUIStain>();
            if (baseUIForm == null)
            {
                Debug.Log("baseUiForm==null! ,请先确认窗体预设对象上是否加载了baseUIForm的子类脚本！ 参数 uiFormName="+uiFormName);
                return null;
            }
            switch (baseUIForm.ExtinctUIOnce.UIForms_Type)
            {
                case UIFormType.Normal:
                    goCloneUIPrefabs.transform.SetParent(_YetVerify, false);
                    break;
                case UIFormType.Fixed:
                    goCloneUIPrefabs.transform.SetParent(_YetMagma, false);
                    break;
                case UIFormType.PopUp:
                    goCloneUIPrefabs.transform.SetParent(_YetEatNo, false);
                    break;
                case UIFormType.Top:
                    goCloneUIPrefabs.transform.SetParent(_Ear, false);
                    break;
                default:
                    break;
            }
            //设置隐藏
            goCloneUIPrefabs.SetActive(false);
            //把克隆体，加入到所有ui窗体缓存集合中
            _LopALLUIStain.Add(uiFormName, baseUIForm);
            return baseUIForm;
        }
        else
        {
            Debug.Log("_TraCanvasTransfrom==null Or goCloneUIPrefabs==null!! ,Plese Check!, 参数uiFormName=" + uiFormName);
        }
        Debug.Log("出现不可以预估的错误，请检查，参数 uiFormName=" + uiFormName);
        return null;
    }
    /// <summary>
    /// 把当前窗体加载到当前窗体集合中
    /// </summary>
    /// <param name="uiFormName">窗体预设的名字</param>
    private void BrawlUIStainTonal(string uiFormName)
    {
        //ui窗体基类
        GoldUIStain baseUIForm;
        //从所有窗体集合中得到的窗体
        GoldUIStain baseUIFormFromAllCache;
        //如果正在显示的集合中存在该窗体，直接返回
        _LopExtinctPearUIStain.TryGetValue(uiFormName, out baseUIForm);
        if (baseUIForm != null) return;
        //把当前窗体，加载到正在显示集合中
        _LopALLUIStain.TryGetValue(uiFormName, out baseUIFormFromAllCache);
        if (baseUIFormFromAllCache != null)
        {
            _LopExtinctPearUIStain.Add(uiFormName, baseUIFormFromAllCache);
            //显示当前窗体
            baseUIFormFromAllCache.Display();
            
        }
    }

    /// <summary>
    /// 卸载ui窗体从当前显示的集合缓存中
    /// </summary>
    /// <param name="strUIFormsName"></param>
    private void DareUIStainTonal(string strUIFormsName)
    {
        //ui窗体基类
        GoldUIStain baseUIForms;
        //正在显示ui窗体缓存集合没有记录，则直接返回
        _LopExtinctPearUIStain.TryGetValue(strUIFormsName, out baseUIForms);
        if (baseUIForms == null) return;
        //指定ui窗体，运行隐藏，且从正在显示ui窗体缓存集合中移除
        baseUIForms.Hidding();
        _LopExtinctPearUIStain.Remove(strUIFormsName);
    }

    /// <summary>
    /// 加载ui窗体到当前显示窗体集合，且，隐藏其他正在显示的页面
    /// </summary>
    /// <param name="strUIFormsName"></param>
    private void BrawlUITraderNoTonalAfarOther(string strUIFormsName)
    {
        //窗体基类
        GoldUIStain baseUIForms;
        //所有窗体集合中的窗体基类
        GoldUIStain baseUIFormsFromAllCache;
        _LopExtinctPearUIStain.TryGetValue(strUIFormsName, out baseUIForms);
        //正在显示ui窗体缓存集合里有记录，直接返回
        if (baseUIForms != null) return;
        Debug.Log("关闭其他窗体");
        //正在显示ui窗体缓存 与栈缓存集合里所有的窗体进行隐藏处理
        List<GoldUIStain> ShowUIFormsList = new List<GoldUIStain>(_LopExtinctPearUIStain.Values);
        foreach (GoldUIStain baseUIFormsItem in ShowUIFormsList)
        {
            //Debug.Log("_DicCurrentShowUIForms---------" + baseUIFormsItem.transform.name);
            if (baseUIFormsItem.ExtinctUIOnce.UIForms_Type == UIFormType.PopUp)
            {
                //baseUIFormsItem.Hidding();
                DareUIStainPermTonalBigPearTroop(baseUIFormsItem.GetType().Name);
            }
        }
        List<GoldUIStain> CurrentUIFormsList = new List<GoldUIStain>(_StaExtinctUIStain);
        foreach (GoldUIStain baseUIFormsItem in CurrentUIFormsList)
        {
            //Debug.Log("_StaCurrentUIForms---------"+baseUIFormsItem.transform.name);
            //baseUIFormsItem.Hidding();
            DareUIStainPermTonalBigPearTroop(baseUIFormsItem.GetType().Name);
        }
        //把当前窗体，加载到正在显示ui窗体缓存集合中 
        _LopALLUIStain.TryGetValue(strUIFormsName, out baseUIFormsFromAllCache);
        if (baseUIFormsFromAllCache != null)
        {
            _LopExtinctPearUIStain.Add(strUIFormsName, baseUIFormsFromAllCache);
            baseUIFormsFromAllCache.Display();
        }
    }
    /// <summary>
    /// 把当前窗体加载到当前窗体集合中
    /// </summary>
    /// <param name="uiFormName">窗体预设的名字</param>
    private void BrawlUIStainTonalMoatFolly(string uiFormName)
    {
        //ui窗体基类
        GoldUIStain baseUIForm;
        //从所有窗体集合中得到的窗体
        GoldUIStain baseUIFormFromAllCache;
        //如果正在显示的集合中存在该窗体，直接返回
        _LopExtinctPearUIStain.TryGetValue(uiFormName, out baseUIForm);
        if (baseUIForm != null) return;
        bool havePopUp = false;
        foreach (GoldUIStain uiforms in _LopExtinctPearUIStain.Values)
        {
            if (uiforms.ExtinctUIOnce.UIForms_Type == UIFormType.PopUp)
            {
                havePopUp = true;
                break;
            }
        }
        if (!havePopUp)
        {
            //把当前窗体，加载到正在显示集合中
            _LopALLUIStain.TryGetValue(uiFormName, out baseUIFormFromAllCache);
            if (baseUIFormFromAllCache != null)
            {
                _LopExtinctPearUIStain.Add(uiFormName, baseUIFormFromAllCache);
                //显示当前窗体
                baseUIFormFromAllCache.Display();

            }
        }
        else
        {
            _MoatUIStain.Add(uiFormName);
        }
        
    }
    /// <summary>
    /// 卸载ui窗体从当前显示窗体集合缓存中，且显示其他原本需要显示的页面
    /// </summary>
    /// <param name="strUIFormsName"></param>
    private void DareUIStainPermTonalBigPearTroop(string strUIFormsName)
    {
        //ui窗体基类
        GoldUIStain baseUIForms;
        _LopExtinctPearUIStain.TryGetValue(strUIFormsName, out baseUIForms);
        if (baseUIForms == null) return;
        //指定ui窗体 ，运行隐藏状态，且从正在显示ui窗体缓存集合中删除
        baseUIForms.Hidding();
        _LopExtinctPearUIStain.Remove(strUIFormsName);
        //正在显示ui窗体缓存与栈缓存集合里素有窗体进行再次显示
        //foreach (GoldUIStain baseUIFormsItem in _DicCurrentShowUIForms.Values)
        //{
        //    baseUIFormsItem.Redisplay();
        //}
        //foreach (GoldUIStain baseUIFormsItem in _StaCurrentUIForms)
        //{
        //    baseUIFormsItem.Redisplay();
        //}
    }
    /// <summary>
    /// ui窗体入栈
    /// 功能：1判断栈里是否已经有窗体，有则冻结
    ///   2先判断ui预设缓存集合是否有指定的ui窗体，有则处理
    ///   3指定ui窗体入栈
    /// </summary>
    /// <param name="strUIFormsName"></param>
    private void SourUIStain(string strUIFormsName)
    {
        //ui预设窗体
        GoldUIStain baseUI;
        //判断栈里是否已经有窗体,有则冻结
        if (_StaExtinctUIStain.Count > 0)
        {
            GoldUIStain topUIForms = _StaExtinctUIStain.Peek();
            topUIForms.Unseen();
            //Debug.Log("topUIForms是" + topUIForms.name);
        }
        //先判断ui预设缓存集合是否有指定ui窗体，有则处理
        _LopALLUIStain.TryGetValue(strUIFormsName, out baseUI);
        if (baseUI != null)
        {
            baseUI.Display();
        }
        else
        {
            Debug.Log(string.Format("/PushUIForms()/ baseUI==null! 核心错误，请检查 strUIFormsName={0} ", strUIFormsName));
        }
        //指定ui窗体入栈
        _StaExtinctUIStain.Push(baseUI);
       
    }

    /// <summary>
    /// ui窗体出栈逻辑
    /// </summary>
    private void EatUIStain()
    {

        if (_StaExtinctUIStain.Count >= 2)
        {
            //出栈逻辑
            GoldUIStain topUIForms = _StaExtinctUIStain.Pop();
            //出栈的窗体进行隐藏
            topUIForms.Hidding(() => {
                //出栈窗体的下一个窗体逻辑
                GoldUIStain nextUIForms = _StaExtinctUIStain.Peek();
                //下一个窗体重新显示处理
                nextUIForms.Redisplay();
            });
        }
        else if (_StaExtinctUIStain.Count == 1)
        {
            GoldUIStain topUIForms = _StaExtinctUIStain.Pop();
            //出栈的窗体进行隐藏处理
            topUIForms.Hidding();
        }
    }


    /// <summary>
    /// 初始化ui窗体预设路径数据
    /// </summary>
    private void PassUIStainOrbitBulk()
    {
        IShieldUncover configMgr = new ShieldUncoverAtFond(EndLondon.SYS_PATH_UIFORMS_CONFIG_INFO);
        if (_LopStainOrbit != null)
        {
            _LopStainOrbit = configMgr.BigWhittle;
        }
    }

    /// <summary>
    /// 清空栈结构体集合
    /// </summary>
    /// <returns></returns>
    private bool SouthShrubCause()
    {
        if(_StaExtinctUIStain!=null && _StaExtinctUIStain.Count >= 1)
        {
            _StaExtinctUIStain.Clear();
            return true;
        }
        return false;
    }
    /// <summary>
    /// 获取当前弹框ui的栈
    /// </summary>
    /// <returns></returns>
    public Stack<GoldUIStain> TowExtinctPeakShrub()
    {
        return _StaExtinctUIStain;
    }


    /// <summary>
    /// 根据panel名称获取panel gameObject
    /// </summary>
    /// <param name="uiFormName"></param>
    /// <returns></returns>
    public GameObject TowPlankAtHail(string uiFormName)
    {
        //ui窗体基类
        GoldUIStain baseUIForm;
        //如果正在显示的集合中存在该窗体，直接返回
        _LopALLUIStain.TryGetValue(uiFormName, out baseUIForm);
        return baseUIForm?.gameObject;
    }

    /// <summary>
    /// 获取所有打开的panel（不包括Normal）
    /// </summary>
    /// <returns></returns>
    public List<GameObject> TowCoamingMarvel(bool containNormal = false)
    {
        List<GameObject> openingPanels = new List<GameObject>();
        List<GoldUIStain> allUIFormsList = new List<GoldUIStain>(_LopALLUIStain.Values);
        foreach(GoldUIStain panel in allUIFormsList)
        {
            if (panel.gameObject.activeInHierarchy)
            {
                if (containNormal || panel._ExtinctUIOnce.UIForms_Type != UIFormType.Normal)
                {
                    openingPanels.Add(panel.gameObject);
                }
            }
        }

        return openingPanels;
    }
}

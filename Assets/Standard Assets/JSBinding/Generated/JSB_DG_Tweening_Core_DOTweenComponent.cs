﻿
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by CSGenerator.
// </auto-generated>
//------------------------------------------------------------------------------
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using DG.Tweening.Core;

using jsval = JSApi.jsval;

public class JSB_DG_Tweening_Core_DOTweenComponent
{

////////////////////// DOTweenComponent ///////////////////////////////////////
// constructors

static bool DOTweenComponent_DOTweenComponent1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new DG.Tweening.Core.DOTweenComponent());
    }

    return true;
}

// fields
static void DOTweenComponent_inspectorUpdater(JSVCall vc)
{
    if (vc.bGet) {
        DG.Tweening.Core.DOTweenComponent _this = (DG.Tweening.Core.DOTweenComponent)vc.csObj;
        var result = _this.inspectorUpdater;
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(result));
    }
    else {
        System.Int32 arg0 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        DG.Tweening.Core.DOTweenComponent _this = (DG.Tweening.Core.DOTweenComponent)vc.csObj;
        _this.inspectorUpdater = arg0;
    }
}

// properties

// methods

static bool DOTweenComponent_SetCapacity__Int32__Int32(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        System.Int32 arg0 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        System.Int32 arg1 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((DG.Tweening.Core.DOTweenComponent)vc.csObj).SetCapacity(arg0, arg1));
    }

    return true;
}


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(DG.Tweening.Core.DOTweenComponent);
    ci.fields = new JSMgr.CSCallbackField[]
    {
        DOTweenComponent_inspectorUpdater,

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(DOTweenComponent_DOTweenComponent1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(DOTweenComponent_SetCapacity__Int32__Int32, "SetCapacity"),

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}

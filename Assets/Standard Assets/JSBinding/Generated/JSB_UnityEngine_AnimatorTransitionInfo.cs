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

using jsval = JSApi.jsval;

public class JSB_UnityEngine_AnimatorTransitionInfo
{

////////////////////// AnimatorTransitionInfo ///////////////////////////////////////
// constructors
public static ConstructorID constructorID0 = new ConstructorID(null, null);

static bool AnimatorTransitionInfo_AnimatorTransitionInfo1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.AnimatorTransitionInfo());
    }

    return true;
}

// fields

// properties
static void AnimatorTransitionInfo_fullPathHash(JSVCall vc)
{
        UnityEngine.AnimatorTransitionInfo _this = (UnityEngine.AnimatorTransitionInfo)vc.csObj;
        var result = _this.fullPathHash;
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(result));
}
static void AnimatorTransitionInfo_nameHash(JSVCall vc)
{
        UnityEngine.AnimatorTransitionInfo _this = (UnityEngine.AnimatorTransitionInfo)vc.csObj;
        var result = _this.nameHash;
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(result));
}
static void AnimatorTransitionInfo_userNameHash(JSVCall vc)
{
        UnityEngine.AnimatorTransitionInfo _this = (UnityEngine.AnimatorTransitionInfo)vc.csObj;
        var result = _this.userNameHash;
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(result));
}
static void AnimatorTransitionInfo_normalizedTime(JSVCall vc)
{
        UnityEngine.AnimatorTransitionInfo _this = (UnityEngine.AnimatorTransitionInfo)vc.csObj;
        var result = _this.normalizedTime;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
}
static void AnimatorTransitionInfo_anyState(JSVCall vc)
{
        UnityEngine.AnimatorTransitionInfo _this = (UnityEngine.AnimatorTransitionInfo)vc.csObj;
        var result = _this.anyState;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
}

// methods

static bool AnimatorTransitionInfo_IsName__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
UnityEngine.AnimatorTransitionInfo argThis = (UnityEngine.AnimatorTransitionInfo)vc.csObj;                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(argThis.IsName(arg0)));
        JSMgr.changeJSObj(vc.jsObjID, argThis);
    }

    return true;
}

static bool AnimatorTransitionInfo_IsUserName__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
UnityEngine.AnimatorTransitionInfo argThis = (UnityEngine.AnimatorTransitionInfo)vc.csObj;                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(argThis.IsUserName(arg0)));
        JSMgr.changeJSObj(vc.jsObjID, argThis);
    }

    return true;
}


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.AnimatorTransitionInfo);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        AnimatorTransitionInfo_fullPathHash,
        AnimatorTransitionInfo_nameHash,
        AnimatorTransitionInfo_userNameHash,
        AnimatorTransitionInfo_normalizedTime,
        AnimatorTransitionInfo_anyState,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(AnimatorTransitionInfo_AnimatorTransitionInfo1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(AnimatorTransitionInfo_IsName__String, "IsName"),
        new JSMgr.MethodCallBackInfo(AnimatorTransitionInfo_IsUserName__String, "IsUserName"),

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}

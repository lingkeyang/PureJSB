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

public class JSB_UnityEngine_Collision2D
{

////////////////////// Collision2D ///////////////////////////////////////
// constructors

static bool Collision2D_Collision2D1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.Collision2D());
    }

    return true;
}

// fields

// properties
static void Collision2D_enabled(JSVCall vc)
{
        UnityEngine.Collision2D _this = (UnityEngine.Collision2D)vc.csObj;
        var result = _this.enabled;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
}
static void Collision2D_rigidbody(JSVCall vc)
{
        UnityEngine.Collision2D _this = (UnityEngine.Collision2D)vc.csObj;
        var result = _this.rigidbody;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
}
static void Collision2D_collider(JSVCall vc)
{
        UnityEngine.Collision2D _this = (UnityEngine.Collision2D)vc.csObj;
        var result = _this.collider;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
}
static void Collision2D_transform(JSVCall vc)
{
        UnityEngine.Collision2D _this = (UnityEngine.Collision2D)vc.csObj;
        var result = _this.transform;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
}
static void Collision2D_gameObject(JSVCall vc)
{
        UnityEngine.Collision2D _this = (UnityEngine.Collision2D)vc.csObj;
        var result = _this.gameObject;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
}
static void Collision2D_contacts(JSVCall vc)
{
        UnityEngine.Collision2D _this = (UnityEngine.Collision2D)vc.csObj;
        var result = _this.contacts;
                var arrRet = result;
        for (int i = 0; arrRet != null && i < arrRet.Length; i++)
        {
            JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
            JSApi.moveSaveID2Arr(i);
        }
        JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
}
static void Collision2D_relativeVelocity(JSVCall vc)
{
        UnityEngine.Collision2D _this = (UnityEngine.Collision2D)vc.csObj;
        var result = _this.relativeVelocity;
                JSApi.setVector2S((int)JSApi.SetType.Rval, result);
}

// methods


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.Collision2D);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        Collision2D_enabled,
        Collision2D_rigidbody,
        Collision2D_collider,
        Collision2D_transform,
        Collision2D_gameObject,
        Collision2D_contacts,
        Collision2D_relativeVelocity,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(Collision2D_Collision2D1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}

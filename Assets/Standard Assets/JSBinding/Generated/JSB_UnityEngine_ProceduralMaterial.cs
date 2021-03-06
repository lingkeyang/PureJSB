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

public class JSB_UnityEngine_ProceduralMaterial
{

////////////////////// ProceduralMaterial ///////////////////////////////////////
// constructors

static bool ProceduralMaterial_ProceduralMaterial1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.ProceduralMaterial());
    }

    return true;
}

// fields

// properties
static void ProceduralMaterial_cacheSize(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ProceduralMaterial _this = (UnityEngine.ProceduralMaterial)vc.csObj;
        var result = _this.cacheSize;
                JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
    }
    else
    { 
        UnityEngine.ProceduralCacheSize arg0 = (UnityEngine.ProceduralCacheSize)JSApi.getEnum((int)JSApi.GetType.Arg);
        UnityEngine.ProceduralMaterial _this = (UnityEngine.ProceduralMaterial)vc.csObj;
        _this.cacheSize = arg0;
    }
}
static void ProceduralMaterial_animationUpdateRate(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ProceduralMaterial _this = (UnityEngine.ProceduralMaterial)vc.csObj;
        var result = _this.animationUpdateRate;
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(result));
    }
    else
    { 
        System.Int32 arg0 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        UnityEngine.ProceduralMaterial _this = (UnityEngine.ProceduralMaterial)vc.csObj;
        _this.animationUpdateRate = arg0;
    }
}
static void ProceduralMaterial_isProcessing(JSVCall vc)
{
        UnityEngine.ProceduralMaterial _this = (UnityEngine.ProceduralMaterial)vc.csObj;
        var result = _this.isProcessing;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
}
static void ProceduralMaterial_isCachedDataAvailable(JSVCall vc)
{
        UnityEngine.ProceduralMaterial _this = (UnityEngine.ProceduralMaterial)vc.csObj;
        var result = _this.isCachedDataAvailable;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
}
static void ProceduralMaterial_isLoadTimeGenerated(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ProceduralMaterial _this = (UnityEngine.ProceduralMaterial)vc.csObj;
        var result = _this.isLoadTimeGenerated;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
    }
    else
    { 
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.ProceduralMaterial _this = (UnityEngine.ProceduralMaterial)vc.csObj;
        _this.isLoadTimeGenerated = arg0;
    }
}
static void ProceduralMaterial_loadingBehavior(JSVCall vc)
{
        UnityEngine.ProceduralMaterial _this = (UnityEngine.ProceduralMaterial)vc.csObj;
        var result = _this.loadingBehavior;
                JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
}
static void ProceduralMaterial_isSupported(JSVCall vc)
{
        var result = UnityEngine.ProceduralMaterial.isSupported;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
}
static void ProceduralMaterial_substanceProcessorUsage(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.ProceduralMaterial.substanceProcessorUsage;
                JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
    }
    else
    { 
        UnityEngine.ProceduralProcessorUsage arg0 = (UnityEngine.ProceduralProcessorUsage)JSApi.getEnum((int)JSApi.GetType.Arg);
        UnityEngine.ProceduralMaterial.substanceProcessorUsage = arg0;
    }
}
static void ProceduralMaterial_preset(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ProceduralMaterial _this = (UnityEngine.ProceduralMaterial)vc.csObj;
        var result = _this.preset;
                JSApi.setStringS((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        UnityEngine.ProceduralMaterial _this = (UnityEngine.ProceduralMaterial)vc.csObj;
        _this.preset = arg0;
    }
}
static void ProceduralMaterial_isReadable(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.ProceduralMaterial _this = (UnityEngine.ProceduralMaterial)vc.csObj;
        var result = _this.isReadable;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
    }
    else
    { 
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.ProceduralMaterial _this = (UnityEngine.ProceduralMaterial)vc.csObj;
        _this.isReadable = arg0;
    }
}

// methods

static bool ProceduralMaterial_CacheProceduralProperty__String__Boolean(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.Boolean arg1 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        ((UnityEngine.ProceduralMaterial)vc.csObj).CacheProceduralProperty(arg0, arg1);
    }

    return true;
}

static bool ProceduralMaterial_ClearCache(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
        ((UnityEngine.ProceduralMaterial)vc.csObj).ClearCache();
    }

    return true;
}

static bool ProceduralMaterial_GetGeneratedTexture__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.ProceduralMaterial)vc.csObj).GetGeneratedTexture(arg0));
    }

    return true;
}

static bool ProceduralMaterial_GetGeneratedTextures(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
                var arrRet = ((UnityEngine.ProceduralMaterial)vc.csObj).GetGeneratedTextures();
        for (int i = 0; arrRet != null && i < arrRet.Length; i++)
        {
            JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
            JSApi.moveSaveID2Arr(i);
        }
        JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
    }

    return true;
}

static bool ProceduralMaterial_GetProceduralBoolean__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(((UnityEngine.ProceduralMaterial)vc.csObj).GetProceduralBoolean(arg0)));
    }

    return true;
}

static bool ProceduralMaterial_GetProceduralColor__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.ProceduralMaterial)vc.csObj).GetProceduralColor(arg0));
    }

    return true;
}

static bool ProceduralMaterial_GetProceduralEnum__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(((UnityEngine.ProceduralMaterial)vc.csObj).GetProceduralEnum(arg0)));
    }

    return true;
}

static bool ProceduralMaterial_GetProceduralFloat__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(((UnityEngine.ProceduralMaterial)vc.csObj).GetProceduralFloat(arg0)));
    }

    return true;
}

static bool ProceduralMaterial_GetProceduralPropertyDescriptions(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
                var arrRet = ((UnityEngine.ProceduralMaterial)vc.csObj).GetProceduralPropertyDescriptions();
        for (int i = 0; arrRet != null && i < arrRet.Length; i++)
        {
            JSMgr.datax.setObject((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
            JSApi.moveSaveID2Arr(i);
        }
        JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
    }

    return true;
}

static bool ProceduralMaterial_GetProceduralTexture__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.ProceduralMaterial)vc.csObj).GetProceduralTexture(arg0));
    }

    return true;
}

static bool ProceduralMaterial_GetProceduralVector__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.ProceduralMaterial)vc.csObj).GetProceduralVector(arg0));
    }

    return true;
}

static bool ProceduralMaterial_HasProceduralProperty__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(((UnityEngine.ProceduralMaterial)vc.csObj).HasProceduralProperty(arg0)));
    }

    return true;
}

static bool ProceduralMaterial_IsProceduralPropertyCached__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(((UnityEngine.ProceduralMaterial)vc.csObj).IsProceduralPropertyCached(arg0)));
    }

    return true;
}

static bool ProceduralMaterial_RebuildTextures(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
        ((UnityEngine.ProceduralMaterial)vc.csObj).RebuildTextures();
    }

    return true;
}

static bool ProceduralMaterial_RebuildTexturesImmediately(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
        ((UnityEngine.ProceduralMaterial)vc.csObj).RebuildTexturesImmediately();
    }

    return true;
}

static bool ProceduralMaterial_SetProceduralBoolean__String__Boolean(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.Boolean arg1 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        ((UnityEngine.ProceduralMaterial)vc.csObj).SetProceduralBoolean(arg0, arg1);
    }

    return true;
}

static bool ProceduralMaterial_SetProceduralColor__String__Color(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        UnityEngine.Color arg1 = (UnityEngine.Color)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        ((UnityEngine.ProceduralMaterial)vc.csObj).SetProceduralColor(arg0, arg1);
    }

    return true;
}

static bool ProceduralMaterial_SetProceduralEnum__String__Int32(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.Int32 arg1 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        ((UnityEngine.ProceduralMaterial)vc.csObj).SetProceduralEnum(arg0, arg1);
    }

    return true;
}

static bool ProceduralMaterial_SetProceduralFloat__String__Single(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.Single arg1 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        ((UnityEngine.ProceduralMaterial)vc.csObj).SetProceduralFloat(arg0, arg1);
    }

    return true;
}

static bool ProceduralMaterial_SetProceduralTexture__String__Texture2D(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        UnityEngine.Texture2D arg1 = (UnityEngine.Texture2D)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        ((UnityEngine.ProceduralMaterial)vc.csObj).SetProceduralTexture(arg0, arg1);
    }

    return true;
}

static bool ProceduralMaterial_SetProceduralVector__String__Vector4(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        UnityEngine.Vector4 arg1 = (UnityEngine.Vector4)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        ((UnityEngine.ProceduralMaterial)vc.csObj).SetProceduralVector(arg0, arg1);
    }

    return true;
}

static bool ProceduralMaterial_StopRebuilds(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
        UnityEngine.ProceduralMaterial.StopRebuilds();
    }

    return true;
}


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.ProceduralMaterial);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        ProceduralMaterial_cacheSize,
        ProceduralMaterial_animationUpdateRate,
        ProceduralMaterial_isProcessing,
        ProceduralMaterial_isCachedDataAvailable,
        ProceduralMaterial_isLoadTimeGenerated,
        ProceduralMaterial_loadingBehavior,
        ProceduralMaterial_isSupported,
        ProceduralMaterial_substanceProcessorUsage,
        ProceduralMaterial_preset,
        ProceduralMaterial_isReadable,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(ProceduralMaterial_ProceduralMaterial1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(ProceduralMaterial_CacheProceduralProperty__String__Boolean, "CacheProceduralProperty"),
        new JSMgr.MethodCallBackInfo(ProceduralMaterial_ClearCache, "ClearCache"),
        new JSMgr.MethodCallBackInfo(ProceduralMaterial_GetGeneratedTexture__String, "GetGeneratedTexture"),
        new JSMgr.MethodCallBackInfo(ProceduralMaterial_GetGeneratedTextures, "GetGeneratedTextures"),
        new JSMgr.MethodCallBackInfo(ProceduralMaterial_GetProceduralBoolean__String, "GetProceduralBoolean"),
        new JSMgr.MethodCallBackInfo(ProceduralMaterial_GetProceduralColor__String, "GetProceduralColor"),
        new JSMgr.MethodCallBackInfo(ProceduralMaterial_GetProceduralEnum__String, "GetProceduralEnum"),
        new JSMgr.MethodCallBackInfo(ProceduralMaterial_GetProceduralFloat__String, "GetProceduralFloat"),
        new JSMgr.MethodCallBackInfo(ProceduralMaterial_GetProceduralPropertyDescriptions, "GetProceduralPropertyDescriptions"),
        new JSMgr.MethodCallBackInfo(ProceduralMaterial_GetProceduralTexture__String, "GetProceduralTexture"),
        new JSMgr.MethodCallBackInfo(ProceduralMaterial_GetProceduralVector__String, "GetProceduralVector"),
        new JSMgr.MethodCallBackInfo(ProceduralMaterial_HasProceduralProperty__String, "HasProceduralProperty"),
        new JSMgr.MethodCallBackInfo(ProceduralMaterial_IsProceduralPropertyCached__String, "IsProceduralPropertyCached"),
        new JSMgr.MethodCallBackInfo(ProceduralMaterial_RebuildTextures, "RebuildTextures"),
        new JSMgr.MethodCallBackInfo(ProceduralMaterial_RebuildTexturesImmediately, "RebuildTexturesImmediately"),
        new JSMgr.MethodCallBackInfo(ProceduralMaterial_SetProceduralBoolean__String__Boolean, "SetProceduralBoolean"),
        new JSMgr.MethodCallBackInfo(ProceduralMaterial_SetProceduralColor__String__Color, "SetProceduralColor"),
        new JSMgr.MethodCallBackInfo(ProceduralMaterial_SetProceduralEnum__String__Int32, "SetProceduralEnum"),
        new JSMgr.MethodCallBackInfo(ProceduralMaterial_SetProceduralFloat__String__Single, "SetProceduralFloat"),
        new JSMgr.MethodCallBackInfo(ProceduralMaterial_SetProceduralTexture__String__Texture2D, "SetProceduralTexture"),
        new JSMgr.MethodCallBackInfo(ProceduralMaterial_SetProceduralVector__String__Vector4, "SetProceduralVector"),
        new JSMgr.MethodCallBackInfo(ProceduralMaterial_StopRebuilds, "StopRebuilds"),

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}

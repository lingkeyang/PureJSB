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

public class JSB_UnityEngine_Profiler
{

////////////////////// Profiler ///////////////////////////////////////
// constructors

static bool Profiler_Profiler1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.Profiler());
    }

    return true;
}

// fields

// properties
static void Profiler_supported(JSVCall vc)
{
        var result = UnityEngine.Profiler.supported;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
}
static void Profiler_logFile(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.Profiler.logFile;
                JSApi.setStringS((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        UnityEngine.Profiler.logFile = arg0;
    }
}
static void Profiler_enableBinaryLog(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.Profiler.enableBinaryLog;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
    }
    else
    { 
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.Profiler.enableBinaryLog = arg0;
    }
}
static void Profiler_enabled(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.Profiler.enabled;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
    }
    else
    { 
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.Profiler.enabled = arg0;
    }
}
static void Profiler_maxNumberOfSamplesPerFrame(JSVCall vc)
{
    if (vc.bGet)
    { 
        var result = UnityEngine.Profiler.maxNumberOfSamplesPerFrame;
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(result));
    }
    else
    { 
        System.Int32 arg0 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        UnityEngine.Profiler.maxNumberOfSamplesPerFrame = arg0;
    }
}
static void Profiler_usedHeapSize(JSVCall vc)
{
        var result = UnityEngine.Profiler.usedHeapSize;
                JSApi.setUInt32((int)JSApi.SetType.Rval, (System.UInt32)(result));
}

// methods

static bool Profiler_AddFramesFromFile__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        UnityEngine.Profiler.AddFramesFromFile(arg0);
    }

    return true;
}

static bool Profiler_BeginSample__String__UEObject(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        UnityEngine.Object arg1 = (UnityEngine.Object)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.Profiler.BeginSample(arg0, arg1);
    }

    return true;
}

static bool Profiler_BeginSample__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        UnityEngine.Profiler.BeginSample(arg0);
    }

    return true;
}

static bool Profiler_EndSample(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
        UnityEngine.Profiler.EndSample();
    }

    return true;
}

static bool Profiler_GetMonoHeapSize(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
                JSApi.setUInt32((int)JSApi.SetType.Rval, (System.UInt32)(UnityEngine.Profiler.GetMonoHeapSize()));
    }

    return true;
}

static bool Profiler_GetMonoUsedSize(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
                JSApi.setUInt32((int)JSApi.SetType.Rval, (System.UInt32)(UnityEngine.Profiler.GetMonoUsedSize()));
    }

    return true;
}

static bool Profiler_GetRuntimeMemorySize__UEObject(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        UnityEngine.Object arg0 = (UnityEngine.Object)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(UnityEngine.Profiler.GetRuntimeMemorySize(arg0)));
    }

    return true;
}

static bool Profiler_GetTotalAllocatedMemory(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
                JSApi.setUInt32((int)JSApi.SetType.Rval, (System.UInt32)(UnityEngine.Profiler.GetTotalAllocatedMemory()));
    }

    return true;
}

static bool Profiler_GetTotalReservedMemory(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
                JSApi.setUInt32((int)JSApi.SetType.Rval, (System.UInt32)(UnityEngine.Profiler.GetTotalReservedMemory()));
    }

    return true;
}

static bool Profiler_GetTotalUnusedReservedMemory(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
                JSApi.setUInt32((int)JSApi.SetType.Rval, (System.UInt32)(UnityEngine.Profiler.GetTotalUnusedReservedMemory()));
    }

    return true;
}


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.Profiler);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        Profiler_supported,
        Profiler_logFile,
        Profiler_enableBinaryLog,
        Profiler_enabled,
        Profiler_maxNumberOfSamplesPerFrame,
        Profiler_usedHeapSize,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(Profiler_Profiler1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(Profiler_AddFramesFromFile__String, "AddFramesFromFile"),
        new JSMgr.MethodCallBackInfo(Profiler_BeginSample__String__UEObject, "BeginSample"),
        new JSMgr.MethodCallBackInfo(Profiler_BeginSample__String, "BeginSample"),
        new JSMgr.MethodCallBackInfo(Profiler_EndSample, "EndSample"),
        new JSMgr.MethodCallBackInfo(Profiler_GetMonoHeapSize, "GetMonoHeapSize"),
        new JSMgr.MethodCallBackInfo(Profiler_GetMonoUsedSize, "GetMonoUsedSize"),
        new JSMgr.MethodCallBackInfo(Profiler_GetRuntimeMemorySize__UEObject, "GetRuntimeMemorySize"),
        new JSMgr.MethodCallBackInfo(Profiler_GetTotalAllocatedMemory, "GetTotalAllocatedMemory"),
        new JSMgr.MethodCallBackInfo(Profiler_GetTotalReservedMemory, "GetTotalReservedMemory"),
        new JSMgr.MethodCallBackInfo(Profiler_GetTotalUnusedReservedMemory, "GetTotalUnusedReservedMemory"),

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}

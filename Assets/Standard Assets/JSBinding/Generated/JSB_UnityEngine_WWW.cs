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
using System.Text;

using jsval = JSApi.jsval;

public class JSB_UnityEngine_WWW
{

////////////////////// WWW ///////////////////////////////////////
// constructors

static bool WWW_WWW1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 1)
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        JSMgr.addJSCSRel(_this, new UnityEngine.WWW(arg0));
    }

    return true;
}

static bool WWW_WWW2(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 2)
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        UnityEngine.WWWForm arg1 = (UnityEngine.WWWForm)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        JSMgr.addJSCSRel(_this, new UnityEngine.WWW(arg0, arg1));
    }

    return true;
}

static bool WWW_WWW3(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 2)
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.Byte[] arg1 = JSDataExchangeMgr.GetJSArg<System.Byte[]>(() =>
        {
            int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
            int length = JSApi.getArrayLength(jsObjID);
            var ret = new System.Byte[length];
            for (var i = 0; i < length; i++) {
                JSApi.getElement(jsObjID, i);
                ret[i] = (System.Byte)JSApi.getByte((int)JSApi.GetType.SaveAndRemove);
            }
            return ret;
        });
        JSMgr.addJSCSRel(_this, new UnityEngine.WWW(arg0, arg1));
    }

    return true;
}

static bool WWW_WWW4(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 3)
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.Byte[] arg1 = JSDataExchangeMgr.GetJSArg<System.Byte[]>(() =>
        {
            int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
            int length = JSApi.getArrayLength(jsObjID);
            var ret = new System.Byte[length];
            for (var i = 0; i < length; i++) {
                JSApi.getElement(jsObjID, i);
                ret[i] = (System.Byte)JSApi.getByte((int)JSApi.GetType.SaveAndRemove);
            }
            return ret;
        });
        Dictionary<System.String, System.String> arg2 = (Dictionary<System.String, System.String>)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        JSMgr.addJSCSRel(_this, new UnityEngine.WWW(arg0, arg1, arg2));
    }

    return true;
}

// fields

// properties
static void WWW_responseHeaders(JSVCall vc)
{
        UnityEngine.WWW _this = (UnityEngine.WWW)vc.csObj;
        var result = _this.responseHeaders;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
}
static void WWW_text(JSVCall vc)
{
        UnityEngine.WWW _this = (UnityEngine.WWW)vc.csObj;
        var result = _this.text;
                JSApi.setStringS((int)JSApi.SetType.Rval, result);
}
static void WWW_bytes(JSVCall vc)
{
        UnityEngine.WWW _this = (UnityEngine.WWW)vc.csObj;
        var result = _this.bytes;
                var arrRet = result;
        for (int i = 0; arrRet != null && i < arrRet.Length; i++)
        {
            JSApi.setByte((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
            JSApi.moveSaveID2Arr(i);
        }
        JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
}
static void WWW_size(JSVCall vc)
{
        UnityEngine.WWW _this = (UnityEngine.WWW)vc.csObj;
        var result = _this.size;
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(result));
}
static void WWW_error(JSVCall vc)
{
        UnityEngine.WWW _this = (UnityEngine.WWW)vc.csObj;
        var result = _this.error;
                JSApi.setStringS((int)JSApi.SetType.Rval, result);
}
static void WWW_texture(JSVCall vc)
{
        UnityEngine.WWW _this = (UnityEngine.WWW)vc.csObj;
        var result = _this.texture;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
}
static void WWW_textureNonReadable(JSVCall vc)
{
        UnityEngine.WWW _this = (UnityEngine.WWW)vc.csObj;
        var result = _this.textureNonReadable;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
}
static void WWW_audioClip(JSVCall vc)
{
        UnityEngine.WWW _this = (UnityEngine.WWW)vc.csObj;
        var result = _this.audioClip;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
}
static void WWW_isDone(JSVCall vc)
{
        UnityEngine.WWW _this = (UnityEngine.WWW)vc.csObj;
        var result = _this.isDone;
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(result));
}
static void WWW_progress(JSVCall vc)
{
        UnityEngine.WWW _this = (UnityEngine.WWW)vc.csObj;
        var result = _this.progress;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
}
static void WWW_uploadProgress(JSVCall vc)
{
        UnityEngine.WWW _this = (UnityEngine.WWW)vc.csObj;
        var result = _this.uploadProgress;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
}
static void WWW_bytesDownloaded(JSVCall vc)
{
        UnityEngine.WWW _this = (UnityEngine.WWW)vc.csObj;
        var result = _this.bytesDownloaded;
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(result));
}
static void WWW_url(JSVCall vc)
{
        UnityEngine.WWW _this = (UnityEngine.WWW)vc.csObj;
        var result = _this.url;
                JSApi.setStringS((int)JSApi.SetType.Rval, result);
}
static void WWW_assetBundle(JSVCall vc)
{
        UnityEngine.WWW _this = (UnityEngine.WWW)vc.csObj;
        var result = _this.assetBundle;
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, result);
}
static void WWW_threadPriority(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.WWW _this = (UnityEngine.WWW)vc.csObj;
        var result = _this.threadPriority;
                JSApi.setEnum((int)JSApi.SetType.Rval, (int)result);
    }
    else
    { 
        UnityEngine.ThreadPriority arg0 = (UnityEngine.ThreadPriority)JSApi.getEnum((int)JSApi.GetType.Arg);
        UnityEngine.WWW _this = (UnityEngine.WWW)vc.csObj;
        _this.threadPriority = arg0;
    }
}

// methods

static bool WWW_Dispose(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
        ((UnityEngine.WWW)vc.csObj).Dispose();
    }

    return true;
}

static bool WWW_GetAudioClip__Boolean__Boolean__AudioType(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 3) 
    {
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        System.Boolean arg1 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.AudioType arg2 = (UnityEngine.AudioType)JSApi.getEnum((int)JSApi.GetType.Arg);
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.WWW)vc.csObj).GetAudioClip(arg0, arg1, arg2));
    }

    return true;
}

static bool WWW_GetAudioClip__Boolean__Boolean(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        System.Boolean arg1 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.WWW)vc.csObj).GetAudioClip(arg0, arg1));
    }

    return true;
}

static bool WWW_GetAudioClip__Boolean(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.WWW)vc.csObj).GetAudioClip(arg0));
    }

    return true;
}

static bool WWW_GetAudioClipCompressed__Boolean__AudioType(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        UnityEngine.AudioType arg1 = (UnityEngine.AudioType)JSApi.getEnum((int)JSApi.GetType.Arg);
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.WWW)vc.csObj).GetAudioClipCompressed(arg0, arg1));
    }

    return true;
}

static bool WWW_GetAudioClipCompressed__Boolean(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.Boolean arg0 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.WWW)vc.csObj).GetAudioClipCompressed(arg0));
    }

    return true;
}

static bool WWW_GetAudioClipCompressed(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, ((UnityEngine.WWW)vc.csObj).GetAudioClipCompressed());
    }

    return true;
}

static bool WWW_InitWWW__String__Byte_Array__String_Array(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 3) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.Byte[] arg1 = JSDataExchangeMgr.GetJSArg<System.Byte[]>(() =>
        {
            int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
            int length = JSApi.getArrayLength(jsObjID);
            var ret = new System.Byte[length];
            for (var i = 0; i < length; i++) {
                JSApi.getElement(jsObjID, i);
                ret[i] = (System.Byte)JSApi.getByte((int)JSApi.GetType.SaveAndRemove);
            }
            return ret;
        });
        System.String[] arg2 = JSDataExchangeMgr.GetJSArg<System.String[]>(() =>
        {
            int jsObjID = JSApi.getObject((int)JSApi.GetType.Arg);
            int length = JSApi.getArrayLength(jsObjID);
            var ret = new System.String[length];
            for (var i = 0; i < length; i++) {
                JSApi.getElement(jsObjID, i);
                ret[i] = (System.String)JSApi.getStringS((int)JSApi.GetType.SaveAndRemove);
            }
            return ret;
        });
        ((UnityEngine.WWW)vc.csObj).InitWWW(arg0, arg1, arg2);
    }

    return true;
}

static bool WWW_LoadImageIntoTexture__Texture2D(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        UnityEngine.Texture2D arg0 = (UnityEngine.Texture2D)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        ((UnityEngine.WWW)vc.csObj).LoadImageIntoTexture(arg0);
    }

    return true;
}

static bool WWW_LoadUnityWeb(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
        ((UnityEngine.WWW)vc.csObj).LoadUnityWeb();
    }

    return true;
}

static bool WWW_EscapeURL__String__Encoding(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.Text.Encoding arg1 = (System.Text.Encoding)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
                JSApi.setStringS((int)JSApi.SetType.Rval, UnityEngine.WWW.EscapeURL(arg0, arg1));
    }

    return true;
}

static bool WWW_EscapeURL__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
                JSApi.setStringS((int)JSApi.SetType.Rval, UnityEngine.WWW.EscapeURL(arg0));
    }

    return true;
}

static bool WWW_LoadFromCacheOrDownload__String__Int32__UInt32(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 3) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.Int32 arg1 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        System.UInt32 arg2 = (System.UInt32)JSApi.getUInt32((int)JSApi.GetType.Arg);
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.WWW.LoadFromCacheOrDownload(arg0, arg1, arg2));
    }

    return true;
}

static bool WWW_LoadFromCacheOrDownload__String__Int32(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.Int32 arg1 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.WWW.LoadFromCacheOrDownload(arg0, arg1));
    }

    return true;
}

static bool WWW_UnEscapeURL__String__Encoding(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.Text.Encoding arg1 = (System.Text.Encoding)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
                JSApi.setStringS((int)JSApi.SetType.Rval, UnityEngine.WWW.UnEscapeURL(arg0, arg1));
    }

    return true;
}

static bool WWW_UnEscapeURL__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
                JSApi.setStringS((int)JSApi.SetType.Rval, UnityEngine.WWW.UnEscapeURL(arg0));
    }

    return true;
}


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.WWW);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        WWW_responseHeaders,
        WWW_text,
        WWW_bytes,
        WWW_size,
        WWW_error,
        WWW_texture,
        WWW_textureNonReadable,
        WWW_audioClip,
        WWW_isDone,
        WWW_progress,
        WWW_uploadProgress,
        WWW_bytesDownloaded,
        WWW_url,
        WWW_assetBundle,
        WWW_threadPriority,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(WWW_WWW1, ".ctor"),
        new JSMgr.MethodCallBackInfo(WWW_WWW2, ".ctor"),
        new JSMgr.MethodCallBackInfo(WWW_WWW3, ".ctor"),
        new JSMgr.MethodCallBackInfo(WWW_WWW4, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(WWW_Dispose, "Dispose"),
        new JSMgr.MethodCallBackInfo(WWW_GetAudioClip__Boolean__Boolean__AudioType, "GetAudioClip"),
        new JSMgr.MethodCallBackInfo(WWW_GetAudioClip__Boolean__Boolean, "GetAudioClip"),
        new JSMgr.MethodCallBackInfo(WWW_GetAudioClip__Boolean, "GetAudioClip"),
        new JSMgr.MethodCallBackInfo(WWW_GetAudioClipCompressed__Boolean__AudioType, "GetAudioClipCompressed"),
        new JSMgr.MethodCallBackInfo(WWW_GetAudioClipCompressed__Boolean, "GetAudioClipCompressed"),
        new JSMgr.MethodCallBackInfo(WWW_GetAudioClipCompressed, "GetAudioClipCompressed"),
        new JSMgr.MethodCallBackInfo(WWW_InitWWW__String__Byte_Array__String_Array, "InitWWW"),
        new JSMgr.MethodCallBackInfo(WWW_LoadImageIntoTexture__Texture2D, "LoadImageIntoTexture"),
        new JSMgr.MethodCallBackInfo(WWW_LoadUnityWeb, "LoadUnityWeb"),
        new JSMgr.MethodCallBackInfo(WWW_EscapeURL__String__Encoding, "EscapeURL"),
        new JSMgr.MethodCallBackInfo(WWW_EscapeURL__String, "EscapeURL"),
        new JSMgr.MethodCallBackInfo(WWW_LoadFromCacheOrDownload__String__Int32__UInt32, "LoadFromCacheOrDownload"),
        new JSMgr.MethodCallBackInfo(WWW_LoadFromCacheOrDownload__String__Int32, "LoadFromCacheOrDownload"),
        new JSMgr.MethodCallBackInfo(WWW_UnEscapeURL__String__Encoding, "UnEscapeURL"),
        new JSMgr.MethodCallBackInfo(WWW_UnEscapeURL__String, "UnEscapeURL"),

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}

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

public class JSB_APIExportTest_RefObject
{

////////////////////// RefObject ///////////////////////////////////////
// constructors

static bool RefObject_RefObject1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new APIExportTest.RefObject());
    }

    return true;
}

// fields
static void RefObject_Name(JSVCall vc)
{
    if (vc.bGet) {
        APIExportTest.RefObject _this = (APIExportTest.RefObject)vc.csObj;
        var result = _this.Name;
                JSApi.setStringS((int)JSApi.SetType.Rval, result);
    }
    else {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        APIExportTest.RefObject _this = (APIExportTest.RefObject)vc.csObj;
        _this.Name = arg0;
    }
}
static void RefObject_x(JSVCall vc)
{
    if (vc.bGet) {
        APIExportTest.RefObject _this = (APIExportTest.RefObject)vc.csObj;
        var result = _this.x;
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(result));
    }
    else {
        System.Int32 arg0 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        APIExportTest.RefObject _this = (APIExportTest.RefObject)vc.csObj;
        _this.x = arg0;
    }
}
static void RefObject_y(JSVCall vc)
{
    if (vc.bGet) {
        APIExportTest.RefObject _this = (APIExportTest.RefObject)vc.csObj;
        var result = _this.y;
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(result));
    }
    else {
        System.Int32 arg0 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        APIExportTest.RefObject _this = (APIExportTest.RefObject)vc.csObj;
        _this.y = arg0;
    }
}

// properties

// methods

static bool RefObject_PrintLog(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
        ((APIExportTest.RefObject)vc.csObj).PrintLog();
    }

    return true;
}


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(APIExportTest.RefObject);
    ci.fields = new JSMgr.CSCallbackField[]
    {
        RefObject_Name,
        RefObject_x,
        RefObject_y,

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(RefObject_RefObject1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(RefObject_PrintLog, "PrintLog"),

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}

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

public class JSB_UnityEngine_Rect
{

////////////////////// Rect ///////////////////////////////////////
// constructors
public static ConstructorID constructorID0 = new ConstructorID(null, null);

static bool Rect_Rect1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.Rect());
    }

    return true;
}

static bool Rect_Rect2(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 4)
    {
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        System.Single arg1 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        System.Single arg2 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        System.Single arg3 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        JSMgr.addJSCSRel(_this, new UnityEngine.Rect(arg0, arg1, arg2, arg3));
    }

    return true;
}

static bool Rect_Rect3(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 1)
    {
        UnityEngine.Rect arg0 = (UnityEngine.Rect)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        JSMgr.addJSCSRel(_this, new UnityEngine.Rect(arg0));
    }

    return true;
}

// fields

// properties
static void Rect_x(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.Rect _this = (UnityEngine.Rect)vc.csObj;
        var result = _this.x;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.Rect _this = (UnityEngine.Rect)vc.csObj;
        _this.x = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void Rect_y(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.Rect _this = (UnityEngine.Rect)vc.csObj;
        var result = _this.y;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.Rect _this = (UnityEngine.Rect)vc.csObj;
        _this.y = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void Rect_position(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.Rect _this = (UnityEngine.Rect)vc.csObj;
        var result = _this.position;
                JSApi.setVector2S((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSApi.getVector2S((int)JSApi.GetType.Arg);
        UnityEngine.Rect _this = (UnityEngine.Rect)vc.csObj;
        _this.position = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void Rect_center(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.Rect _this = (UnityEngine.Rect)vc.csObj;
        var result = _this.center;
                JSApi.setVector2S((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSApi.getVector2S((int)JSApi.GetType.Arg);
        UnityEngine.Rect _this = (UnityEngine.Rect)vc.csObj;
        _this.center = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void Rect_min(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.Rect _this = (UnityEngine.Rect)vc.csObj;
        var result = _this.min;
                JSApi.setVector2S((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSApi.getVector2S((int)JSApi.GetType.Arg);
        UnityEngine.Rect _this = (UnityEngine.Rect)vc.csObj;
        _this.min = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void Rect_max(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.Rect _this = (UnityEngine.Rect)vc.csObj;
        var result = _this.max;
                JSApi.setVector2S((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSApi.getVector2S((int)JSApi.GetType.Arg);
        UnityEngine.Rect _this = (UnityEngine.Rect)vc.csObj;
        _this.max = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void Rect_width(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.Rect _this = (UnityEngine.Rect)vc.csObj;
        var result = _this.width;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.Rect _this = (UnityEngine.Rect)vc.csObj;
        _this.width = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void Rect_height(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.Rect _this = (UnityEngine.Rect)vc.csObj;
        var result = _this.height;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.Rect _this = (UnityEngine.Rect)vc.csObj;
        _this.height = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void Rect_size(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.Rect _this = (UnityEngine.Rect)vc.csObj;
        var result = _this.size;
                JSApi.setVector2S((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSApi.getVector2S((int)JSApi.GetType.Arg);
        UnityEngine.Rect _this = (UnityEngine.Rect)vc.csObj;
        _this.size = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void Rect_xMin(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.Rect _this = (UnityEngine.Rect)vc.csObj;
        var result = _this.xMin;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.Rect _this = (UnityEngine.Rect)vc.csObj;
        _this.xMin = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void Rect_yMin(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.Rect _this = (UnityEngine.Rect)vc.csObj;
        var result = _this.yMin;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.Rect _this = (UnityEngine.Rect)vc.csObj;
        _this.yMin = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void Rect_xMax(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.Rect _this = (UnityEngine.Rect)vc.csObj;
        var result = _this.xMax;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.Rect _this = (UnityEngine.Rect)vc.csObj;
        _this.xMax = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void Rect_yMax(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.Rect _this = (UnityEngine.Rect)vc.csObj;
        var result = _this.yMax;
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(result));
    }
    else
    { 
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.Rect _this = (UnityEngine.Rect)vc.csObj;
        _this.yMax = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}

// methods

static bool Rect_Contains__Vector3__Boolean(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
        System.Boolean arg1 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
UnityEngine.Rect argThis = (UnityEngine.Rect)vc.csObj;                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(argThis.Contains(arg0, arg1)));
        JSMgr.changeJSObj(vc.jsObjID, argThis);
    }

    return true;
}

static bool Rect_Contains__Vector2(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        UnityEngine.Vector2 arg0 = (UnityEngine.Vector2)JSApi.getVector2S((int)JSApi.GetType.Arg);
UnityEngine.Rect argThis = (UnityEngine.Rect)vc.csObj;                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(argThis.Contains(arg0)));
        JSMgr.changeJSObj(vc.jsObjID, argThis);
    }

    return true;
}

static bool Rect_Contains__Vector3(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
UnityEngine.Rect argThis = (UnityEngine.Rect)vc.csObj;                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(argThis.Contains(arg0)));
        JSMgr.changeJSObj(vc.jsObjID, argThis);
    }

    return true;
}

static bool Rect_Equals__Object(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.Object arg0 = (System.Object)JSMgr.datax.getWhatever((int)JSApi.GetType.Arg);
UnityEngine.Rect argThis = (UnityEngine.Rect)vc.csObj;                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(argThis.Equals(arg0)));
        JSMgr.changeJSObj(vc.jsObjID, argThis);
    }

    return true;
}

static bool Rect_GetHashCode(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
UnityEngine.Rect argThis = (UnityEngine.Rect)vc.csObj;                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(argThis.GetHashCode()));
        JSMgr.changeJSObj(vc.jsObjID, argThis);
    }

    return true;
}

static bool Rect_Overlaps__Rect__Boolean(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        UnityEngine.Rect arg0 = (UnityEngine.Rect)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        System.Boolean arg1 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
UnityEngine.Rect argThis = (UnityEngine.Rect)vc.csObj;                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(argThis.Overlaps(arg0, arg1)));
        JSMgr.changeJSObj(vc.jsObjID, argThis);
    }

    return true;
}

static bool Rect_Overlaps__Rect(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        UnityEngine.Rect arg0 = (UnityEngine.Rect)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
UnityEngine.Rect argThis = (UnityEngine.Rect)vc.csObj;                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(argThis.Overlaps(arg0)));
        JSMgr.changeJSObj(vc.jsObjID, argThis);
    }

    return true;
}

static bool Rect_Set__Single__Single__Single__Single(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 4) 
    {
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        System.Single arg1 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        System.Single arg2 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        System.Single arg3 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
UnityEngine.Rect argThis = (UnityEngine.Rect)vc.csObj;        argThis.Set(arg0, arg1, arg2, arg3);
        JSMgr.changeJSObj(vc.jsObjID, argThis);
    }

    return true;
}

static bool Rect_ToString__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
UnityEngine.Rect argThis = (UnityEngine.Rect)vc.csObj;                JSApi.setStringS((int)JSApi.SetType.Rval, argThis.ToString(arg0));
        JSMgr.changeJSObj(vc.jsObjID, argThis);
    }

    return true;
}

static bool Rect_ToString(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
UnityEngine.Rect argThis = (UnityEngine.Rect)vc.csObj;                JSApi.setStringS((int)JSApi.SetType.Rval, argThis.ToString());
        JSMgr.changeJSObj(vc.jsObjID, argThis);
    }

    return true;
}

static bool Rect_MinMaxRect__Single__Single__Single__Single(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 4) 
    {
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        System.Single arg1 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        System.Single arg2 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        System.Single arg3 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.Rect.MinMaxRect(arg0, arg1, arg2, arg3));
    }

    return true;
}

static bool Rect_NormalizedToPoint__Rect__Vector2(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        UnityEngine.Rect arg0 = (UnityEngine.Rect)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSApi.getVector2S((int)JSApi.GetType.Arg);
                JSApi.setVector2S((int)JSApi.SetType.Rval, UnityEngine.Rect.NormalizedToPoint(arg0, arg1));
    }

    return true;
}

static bool Rect_op_Equality__Rect__Rect(JSVCall vc, int argc)
{
    UnityEngine.Rect arg0 = (UnityEngine.Rect)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
    UnityEngine.Rect arg1 = (UnityEngine.Rect)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(arg0 == arg1));
    return true;
}

static bool Rect_op_Inequality__Rect__Rect(JSVCall vc, int argc)
{
    UnityEngine.Rect arg0 = (UnityEngine.Rect)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
    UnityEngine.Rect arg1 = (UnityEngine.Rect)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(arg0 != arg1));
    return true;
}

static bool Rect_PointToNormalized__Rect__Vector2(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        UnityEngine.Rect arg0 = (UnityEngine.Rect)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        UnityEngine.Vector2 arg1 = (UnityEngine.Vector2)JSApi.getVector2S((int)JSApi.GetType.Arg);
                JSApi.setVector2S((int)JSApi.SetType.Rval, UnityEngine.Rect.PointToNormalized(arg0, arg1));
    }

    return true;
}


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.Rect);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        Rect_x,
        Rect_y,
        Rect_position,
        Rect_center,
        Rect_min,
        Rect_max,
        Rect_width,
        Rect_height,
        Rect_size,
        Rect_xMin,
        Rect_yMin,
        Rect_xMax,
        Rect_yMax,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(Rect_Rect1, ".ctor"),
        new JSMgr.MethodCallBackInfo(Rect_Rect2, ".ctor"),
        new JSMgr.MethodCallBackInfo(Rect_Rect3, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(Rect_Contains__Vector3__Boolean, "Contains"),
        new JSMgr.MethodCallBackInfo(Rect_Contains__Vector2, "Contains"),
        new JSMgr.MethodCallBackInfo(Rect_Contains__Vector3, "Contains"),
        new JSMgr.MethodCallBackInfo(Rect_Equals__Object, "Equals"),
        new JSMgr.MethodCallBackInfo(Rect_GetHashCode, "GetHashCode"),
        new JSMgr.MethodCallBackInfo(Rect_Overlaps__Rect__Boolean, "Overlaps"),
        new JSMgr.MethodCallBackInfo(Rect_Overlaps__Rect, "Overlaps"),
        new JSMgr.MethodCallBackInfo(Rect_Set__Single__Single__Single__Single, "Set"),
        new JSMgr.MethodCallBackInfo(Rect_ToString__String, "ToString"),
        new JSMgr.MethodCallBackInfo(Rect_ToString, "ToString"),
        new JSMgr.MethodCallBackInfo(Rect_MinMaxRect__Single__Single__Single__Single, "MinMaxRect"),
        new JSMgr.MethodCallBackInfo(Rect_NormalizedToPoint__Rect__Vector2, "NormalizedToPoint"),
        new JSMgr.MethodCallBackInfo(Rect_op_Equality__Rect__Rect, "op_Equality"),
        new JSMgr.MethodCallBackInfo(Rect_op_Inequality__Rect__Rect, "op_Inequality"),
        new JSMgr.MethodCallBackInfo(Rect_PointToNormalized__Rect__Vector2, "PointToNormalized"),

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}

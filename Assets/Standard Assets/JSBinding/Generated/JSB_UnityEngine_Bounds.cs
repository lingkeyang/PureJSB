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

public class JSB_UnityEngine_Bounds
{

////////////////////// Bounds ///////////////////////////////////////
// constructors
public static ConstructorID constructorID0 = new ConstructorID(null, null);

static bool Bounds_Bounds1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.Bounds());
    }

    return true;
}

static bool Bounds_Bounds2(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 2)
    {
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
        UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
        JSMgr.addJSCSRel(_this, new UnityEngine.Bounds(arg0, arg1));
    }

    return true;
}

// fields

// properties
static void Bounds_center(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.Bounds _this = (UnityEngine.Bounds)vc.csObj;
        var result = _this.center;
                JSApi.setVector3S((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
        UnityEngine.Bounds _this = (UnityEngine.Bounds)vc.csObj;
        _this.center = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void Bounds_size(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.Bounds _this = (UnityEngine.Bounds)vc.csObj;
        var result = _this.size;
                JSApi.setVector3S((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
        UnityEngine.Bounds _this = (UnityEngine.Bounds)vc.csObj;
        _this.size = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void Bounds_extents(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.Bounds _this = (UnityEngine.Bounds)vc.csObj;
        var result = _this.extents;
                JSApi.setVector3S((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
        UnityEngine.Bounds _this = (UnityEngine.Bounds)vc.csObj;
        _this.extents = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void Bounds_min(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.Bounds _this = (UnityEngine.Bounds)vc.csObj;
        var result = _this.min;
                JSApi.setVector3S((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
        UnityEngine.Bounds _this = (UnityEngine.Bounds)vc.csObj;
        _this.min = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}
static void Bounds_max(JSVCall vc)
{
    if (vc.bGet)
    { 
        UnityEngine.Bounds _this = (UnityEngine.Bounds)vc.csObj;
        var result = _this.max;
                JSApi.setVector3S((int)JSApi.SetType.Rval, result);
    }
    else
    { 
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
        UnityEngine.Bounds _this = (UnityEngine.Bounds)vc.csObj;
        _this.max = arg0;
        JSMgr.changeJSObj(vc.jsObjID, _this);
    }
}

// methods

static bool Bounds_Contains__Vector3(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
UnityEngine.Bounds argThis = (UnityEngine.Bounds)vc.csObj;                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(argThis.Contains(arg0)));
        JSMgr.changeJSObj(vc.jsObjID, argThis);
    }

    return true;
}

static bool Bounds_Encapsulate__Vector3(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
UnityEngine.Bounds argThis = (UnityEngine.Bounds)vc.csObj;        argThis.Encapsulate(arg0);
        JSMgr.changeJSObj(vc.jsObjID, argThis);
    }

    return true;
}

static bool Bounds_Encapsulate__Bounds(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        UnityEngine.Bounds arg0 = (UnityEngine.Bounds)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
UnityEngine.Bounds argThis = (UnityEngine.Bounds)vc.csObj;        argThis.Encapsulate(arg0);
        JSMgr.changeJSObj(vc.jsObjID, argThis);
    }

    return true;
}

static bool Bounds_Equals__Object(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.Object arg0 = (System.Object)JSMgr.datax.getWhatever((int)JSApi.GetType.Arg);
UnityEngine.Bounds argThis = (UnityEngine.Bounds)vc.csObj;                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(argThis.Equals(arg0)));
        JSMgr.changeJSObj(vc.jsObjID, argThis);
    }

    return true;
}

static bool Bounds_Expand__Vector3(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
UnityEngine.Bounds argThis = (UnityEngine.Bounds)vc.csObj;        argThis.Expand(arg0);
        JSMgr.changeJSObj(vc.jsObjID, argThis);
    }

    return true;
}

static bool Bounds_Expand__Single(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.Single arg0 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
UnityEngine.Bounds argThis = (UnityEngine.Bounds)vc.csObj;        argThis.Expand(arg0);
        JSMgr.changeJSObj(vc.jsObjID, argThis);
    }

    return true;
}

static bool Bounds_GetHashCode(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
UnityEngine.Bounds argThis = (UnityEngine.Bounds)vc.csObj;                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(argThis.GetHashCode()));
        JSMgr.changeJSObj(vc.jsObjID, argThis);
    }

    return true;
}

static bool Bounds_IntersectRay__Ray__Single(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        UnityEngine.Ray arg0 = (UnityEngine.Ray)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        int r_arg1 = JSApi.incArgIndex();
        System.Single arg1;
UnityEngine.Bounds argThis = (UnityEngine.Bounds)vc.csObj;                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(argThis.IntersectRay(arg0, out arg1)));
        JSMgr.changeJSObj(vc.jsObjID, argThis);
        JSApi.setArgIndex(r_arg1);
        JSApi.setSingle((int)JSApi.SetType.ArgRef, arg1);
    }

    return true;
}

static bool Bounds_IntersectRay__Ray(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        UnityEngine.Ray arg0 = (UnityEngine.Ray)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
UnityEngine.Bounds argThis = (UnityEngine.Bounds)vc.csObj;                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(argThis.IntersectRay(arg0)));
        JSMgr.changeJSObj(vc.jsObjID, argThis);
    }

    return true;
}

static bool Bounds_Intersects__Bounds(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        UnityEngine.Bounds arg0 = (UnityEngine.Bounds)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
UnityEngine.Bounds argThis = (UnityEngine.Bounds)vc.csObj;                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(argThis.Intersects(arg0)));
        JSMgr.changeJSObj(vc.jsObjID, argThis);
    }

    return true;
}

static bool Bounds_SetMinMax__Vector3__Vector3(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
        UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
UnityEngine.Bounds argThis = (UnityEngine.Bounds)vc.csObj;        argThis.SetMinMax(arg0, arg1);
        JSMgr.changeJSObj(vc.jsObjID, argThis);
    }

    return true;
}

static bool Bounds_SqrDistance__Vector3(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
UnityEngine.Bounds argThis = (UnityEngine.Bounds)vc.csObj;                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(argThis.SqrDistance(arg0)));
        JSMgr.changeJSObj(vc.jsObjID, argThis);
    }

    return true;
}

static bool Bounds_ToString__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
UnityEngine.Bounds argThis = (UnityEngine.Bounds)vc.csObj;                JSApi.setStringS((int)JSApi.SetType.Rval, argThis.ToString(arg0));
        JSMgr.changeJSObj(vc.jsObjID, argThis);
    }

    return true;
}

static bool Bounds_ToString(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
UnityEngine.Bounds argThis = (UnityEngine.Bounds)vc.csObj;                JSApi.setStringS((int)JSApi.SetType.Rval, argThis.ToString());
        JSMgr.changeJSObj(vc.jsObjID, argThis);
    }

    return true;
}

static bool Bounds_op_Equality__Bounds__Bounds(JSVCall vc, int argc)
{
    UnityEngine.Bounds arg0 = (UnityEngine.Bounds)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
    UnityEngine.Bounds arg1 = (UnityEngine.Bounds)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(arg0 == arg1));
    return true;
}

static bool Bounds_op_Inequality__Bounds__Bounds(JSVCall vc, int argc)
{
    UnityEngine.Bounds arg0 = (UnityEngine.Bounds)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
    UnityEngine.Bounds arg1 = (UnityEngine.Bounds)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
            JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(arg0 != arg1));
    return true;
}


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.Bounds);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        Bounds_center,
        Bounds_size,
        Bounds_extents,
        Bounds_min,
        Bounds_max,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(Bounds_Bounds1, ".ctor"),
        new JSMgr.MethodCallBackInfo(Bounds_Bounds2, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(Bounds_Contains__Vector3, "Contains"),
        new JSMgr.MethodCallBackInfo(Bounds_Encapsulate__Vector3, "Encapsulate"),
        new JSMgr.MethodCallBackInfo(Bounds_Encapsulate__Bounds, "Encapsulate"),
        new JSMgr.MethodCallBackInfo(Bounds_Equals__Object, "Equals"),
        new JSMgr.MethodCallBackInfo(Bounds_Expand__Vector3, "Expand"),
        new JSMgr.MethodCallBackInfo(Bounds_Expand__Single, "Expand"),
        new JSMgr.MethodCallBackInfo(Bounds_GetHashCode, "GetHashCode"),
        new JSMgr.MethodCallBackInfo(Bounds_IntersectRay__Ray__Single, "IntersectRay"),
        new JSMgr.MethodCallBackInfo(Bounds_IntersectRay__Ray, "IntersectRay"),
        new JSMgr.MethodCallBackInfo(Bounds_Intersects__Bounds, "Intersects"),
        new JSMgr.MethodCallBackInfo(Bounds_SetMinMax__Vector3__Vector3, "SetMinMax"),
        new JSMgr.MethodCallBackInfo(Bounds_SqrDistance__Vector3, "SqrDistance"),
        new JSMgr.MethodCallBackInfo(Bounds_ToString__String, "ToString"),
        new JSMgr.MethodCallBackInfo(Bounds_ToString, "ToString"),
        new JSMgr.MethodCallBackInfo(Bounds_op_Equality__Bounds__Bounds, "op_Equality"),
        new JSMgr.MethodCallBackInfo(Bounds_op_Inequality__Bounds__Bounds, "op_Inequality"),

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}

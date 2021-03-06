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

public class JSB_System_Collections_Generic_KeyValuePair_2
{

////////////////////// KeyValuePair`2 ///////////////////////////////////////
// constructors
public static ConstructorID constructorID0 = new ConstructorID(null, null);

static bool KeyValuePairA2_KeyValuePairA21(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    ConstructorInfo constructor = JSDataExchangeMgr.makeGenericConstructor(typeof(System.Collections.Generic.KeyValuePair<,>), constructorID0); 
    if (constructor == null) return true;

    int len = argc - 2;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, constructor.Invoke(null, new object[]{}));
    }

    return true;
}
public static ConstructorID constructorID1 = new ConstructorID(new string[]{"TKey", "TValue"}, new TypeFlag[]{TypeFlag.IsT, TypeFlag.IsT});

static bool KeyValuePairA2_KeyValuePairA22(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    ConstructorInfo constructor = JSDataExchangeMgr.makeGenericConstructor(typeof(System.Collections.Generic.KeyValuePair<,>), constructorID1); 
    if (constructor == null) return true;

    int len = argc - 2;
    if (len == 2)
    {
        object arg0 = (object)JSMgr.datax.getWhatever((int)JSApi.GetType.Arg);
        object arg1 = (object)JSMgr.datax.getWhatever((int)JSApi.GetType.Arg);
        JSMgr.addJSCSRel(_this, constructor.Invoke(null, new object[]{arg0, arg1}));
    }

    return true;
}

// fields

// properties
public static PropertyID propertyID0 = new PropertyID("Key", "TKey", TypeFlag.IsT, null, null);
static void KeyValuePairA2_Key(JSVCall vc)
{
    PropertyInfo member = GenericTypeCache.getProperty(vc.csObj.GetType(), propertyID0); 
    if (member == null) return;

        var result = member.GetValue(vc.csObj, new object[]{});
                JSMgr.datax.setWhatever((int)JSApi.SetType.Rval, result);
}
public static PropertyID propertyID1 = new PropertyID("Value", "TValue", TypeFlag.IsT, null, null);
static void KeyValuePairA2_Value(JSVCall vc)
{
    PropertyInfo member = GenericTypeCache.getProperty(vc.csObj.GetType(), propertyID1); 
    if (member == null) return;

        var result = member.GetValue(vc.csObj, new object[]{});
                JSMgr.datax.setWhatever((int)JSApi.SetType.Rval, result);
}

// methods
public static MethodID methodID0 = new MethodID("ToString", "String", TypeFlag.None, null, null);

static bool KeyValuePairA2_ToString(JSVCall vc, int argc)
{
    // Get generic method by name and param count.
    MethodInfo method = GenericTypeCache.getMethod(vc.csObj.GetType(), methodID0); 
    if (method == null) return true;

    int len = argc;
    if (len == 0) 
    {
        object[] arr_t = null;
                JSApi.setStringS((int)JSApi.SetType.Rval, method.Invoke(vc.csObj, arr_t));
    }

    return true;
}


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(System.Collections.Generic.KeyValuePair<,>);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {
        KeyValuePairA2_Key,
        KeyValuePairA2_Value,

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(KeyValuePairA2_KeyValuePairA21, ".ctor"),
        new JSMgr.MethodCallBackInfo(KeyValuePairA2_KeyValuePairA22, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(KeyValuePairA2_ToString, "ToString"),

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}

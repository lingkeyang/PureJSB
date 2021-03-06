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

public class JSB_UnityEngine_NavMesh
{

////////////////////// NavMesh ///////////////////////////////////////
// constructors

static bool NavMesh_NavMesh1(JSVCall vc, int argc)
{
    int _this = JSApi.getObject((int)JSApi.GetType.Arg);
    JSApi.attachFinalizerObject(_this);
    --argc;

    int len = argc;
    if (len == 0)
    {
        JSMgr.addJSCSRel(_this, new UnityEngine.NavMesh());
    }

    return true;
}

// fields

// properties

// methods

static bool NavMesh_AddOffMeshLinks(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
        UnityEngine.NavMesh.AddOffMeshLinks();
    }

    return true;
}

static bool NavMesh_CalculatePath__Vector3__Vector3__Int32__NavMeshPath(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 4) 
    {
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
        UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
        System.Int32 arg2 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        UnityEngine.NavMeshPath arg3 = (UnityEngine.NavMeshPath)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(UnityEngine.NavMesh.CalculatePath(arg0, arg1, arg2, arg3)));
    }

    return true;
}

static bool NavMesh_CalculateTriangulation(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, UnityEngine.NavMesh.CalculateTriangulation());
    }

    return true;
}

static bool NavMesh_FindClosestEdge__Vector3__NavMeshHit__Int32(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 3) 
    {
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
        int r_arg1 = JSApi.incArgIndex();
        UnityEngine.NavMeshHit arg1;
        System.Int32 arg2 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(UnityEngine.NavMesh.FindClosestEdge(arg0, out arg1, arg2)));
        JSApi.setArgIndex(r_arg1);
        JSMgr.datax.setObject((int)JSApi.SetType.ArgRef, arg1);
    }

    return true;
}

static bool NavMesh_GetLayerCost__Int32(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.Int32 arg0 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
                JSApi.setSingle((int)JSApi.SetType.Rval, (System.Single)(UnityEngine.NavMesh.GetLayerCost(arg0)));
    }

    return true;
}

static bool NavMesh_GetNavMeshLayerFromName__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
                JSApi.setInt32((int)JSApi.SetType.Rval, (System.Int32)(UnityEngine.NavMesh.GetNavMeshLayerFromName(arg0)));
    }

    return true;
}

static bool NavMesh_Raycast__Vector3__Vector3__NavMeshHit__Int32(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 4) 
    {
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
        UnityEngine.Vector3 arg1 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
        int r_arg2 = JSApi.incArgIndex();
        UnityEngine.NavMeshHit arg2;
        System.Int32 arg3 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(UnityEngine.NavMesh.Raycast(arg0, arg1, out arg2, arg3)));
        JSApi.setArgIndex(r_arg2);
        JSMgr.datax.setObject((int)JSApi.SetType.ArgRef, arg2);
    }

    return true;
}

static bool NavMesh_RestoreNavMesh(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 0) 
    {
        UnityEngine.NavMesh.RestoreNavMesh();
    }

    return true;
}

static bool NavMesh_SamplePosition__Vector3__NavMeshHit__Single__Int32(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 4) 
    {
        UnityEngine.Vector3 arg0 = (UnityEngine.Vector3)JSApi.getVector3S((int)JSApi.GetType.Arg);
        int r_arg1 = JSApi.incArgIndex();
        UnityEngine.NavMeshHit arg1;
        System.Single arg2 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        System.Int32 arg3 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(UnityEngine.NavMesh.SamplePosition(arg0, out arg1, arg2, arg3)));
        JSApi.setArgIndex(r_arg1);
        JSMgr.datax.setObject((int)JSApi.SetType.ArgRef, arg1);
    }

    return true;
}

static bool NavMesh_SetLayerCost__Int32__Single(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        System.Int32 arg0 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
        System.Single arg1 = (System.Single)JSApi.getSingle((int)JSApi.GetType.Arg);
        UnityEngine.NavMesh.SetLayerCost(arg0, arg1);
    }

    return true;
}


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(UnityEngine.NavMesh);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(NavMesh_NavMesh1, ".ctor"),

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(NavMesh_AddOffMeshLinks, "AddOffMeshLinks"),
        new JSMgr.MethodCallBackInfo(NavMesh_CalculatePath__Vector3__Vector3__Int32__NavMeshPath, "CalculatePath"),
        new JSMgr.MethodCallBackInfo(NavMesh_CalculateTriangulation, "CalculateTriangulation"),
        new JSMgr.MethodCallBackInfo(NavMesh_FindClosestEdge__Vector3__NavMeshHit__Int32, "FindClosestEdge"),
        new JSMgr.MethodCallBackInfo(NavMesh_GetLayerCost__Int32, "GetLayerCost"),
        new JSMgr.MethodCallBackInfo(NavMesh_GetNavMeshLayerFromName__String, "GetNavMeshLayerFromName"),
        new JSMgr.MethodCallBackInfo(NavMesh_Raycast__Vector3__Vector3__NavMeshHit__Int32, "Raycast"),
        new JSMgr.MethodCallBackInfo(NavMesh_RestoreNavMesh, "RestoreNavMesh"),
        new JSMgr.MethodCallBackInfo(NavMesh_SamplePosition__Vector3__NavMeshHit__Single__Int32, "SamplePosition"),
        new JSMgr.MethodCallBackInfo(NavMesh_SetLayerCost__Int32__Single, "SetLayerCost"),

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}

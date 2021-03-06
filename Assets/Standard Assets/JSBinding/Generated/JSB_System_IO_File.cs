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
using System.IO;
using System.Security.AccessControl;

using jsval = JSApi.jsval;

public class JSB_System_IO_File
{

////////////////////// File ///////////////////////////////////////
// constructors

// fields

// properties

// methods

static bool File_AppendAllText__String__String__Encoding(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 3) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.String arg1 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.Text.Encoding arg2 = (System.Text.Encoding)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        System.IO.File.AppendAllText(arg0, arg1, arg2);
    }

    return true;
}

static bool File_AppendAllText__String__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.String arg1 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.IO.File.AppendAllText(arg0, arg1);
    }

    return true;
}

static bool File_AppendText__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, System.IO.File.AppendText(arg0));
    }

    return true;
}

static bool File_Copy__String__String__Boolean(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 3) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.String arg1 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.Boolean arg2 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        System.IO.File.Copy(arg0, arg1, arg2);
    }

    return true;
}

static bool File_Copy__String__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.String arg1 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.IO.File.Copy(arg0, arg1);
    }

    return true;
}

static bool File_Create__String__Int32__FileOptions__FileSecurity(JSVCall vc, int argc)
{
    UnityEngine.Debug.LogError("This method is not supported by .Net 2.0 subset.");
    return true;
}

static bool File_Create__String__Int32__FileOptions(JSVCall vc, int argc)
{
    UnityEngine.Debug.LogError("This method is not supported by .Net 2.0 subset.");
    return true;
}

static bool File_Create__String__Int32(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.Int32 arg1 = (System.Int32)JSApi.getInt32((int)JSApi.GetType.Arg);
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, System.IO.File.Create(arg0, arg1));
    }

    return true;
}

static bool File_Create__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, System.IO.File.Create(arg0));
    }

    return true;
}

static bool File_CreateText__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, System.IO.File.CreateText(arg0));
    }

    return true;
}

static bool File_Decrypt__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.IO.File.Decrypt(arg0);
    }

    return true;
}

static bool File_Delete__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.IO.File.Delete(arg0);
    }

    return true;
}

static bool File_Encrypt__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.IO.File.Encrypt(arg0);
    }

    return true;
}

static bool File_Exists__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
                JSApi.setBooleanS((int)JSApi.SetType.Rval, (System.Boolean)(System.IO.File.Exists(arg0)));
    }

    return true;
}

static bool File_GetAccessControl__String__AccessControlSections(JSVCall vc, int argc)
{
    UnityEngine.Debug.LogError("This method is not supported by .Net 2.0 subset.");
    return true;
}

static bool File_GetAccessControl__String(JSVCall vc, int argc)
{
    UnityEngine.Debug.LogError("This method is not supported by .Net 2.0 subset.");
    return true;
}

static bool File_GetAttributes__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
                JSApi.setEnum((int)JSApi.SetType.Rval, (int)System.IO.File.GetAttributes(arg0));
    }

    return true;
}

static bool File_GetCreationTime__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, System.IO.File.GetCreationTime(arg0));
    }

    return true;
}

static bool File_GetCreationTimeUtc__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, System.IO.File.GetCreationTimeUtc(arg0));
    }

    return true;
}

static bool File_GetLastAccessTime__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, System.IO.File.GetLastAccessTime(arg0));
    }

    return true;
}

static bool File_GetLastAccessTimeUtc__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, System.IO.File.GetLastAccessTimeUtc(arg0));
    }

    return true;
}

static bool File_GetLastWriteTime__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, System.IO.File.GetLastWriteTime(arg0));
    }

    return true;
}

static bool File_GetLastWriteTimeUtc__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, System.IO.File.GetLastWriteTimeUtc(arg0));
    }

    return true;
}

static bool File_Move__String__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.String arg1 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.IO.File.Move(arg0, arg1);
    }

    return true;
}

static bool File_Open__String__FileMode__FileAccess__FileShare(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 4) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.IO.FileMode arg1 = (System.IO.FileMode)JSApi.getEnum((int)JSApi.GetType.Arg);
        System.IO.FileAccess arg2 = (System.IO.FileAccess)JSApi.getEnum((int)JSApi.GetType.Arg);
        System.IO.FileShare arg3 = (System.IO.FileShare)JSApi.getEnum((int)JSApi.GetType.Arg);
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, System.IO.File.Open(arg0, arg1, arg2, arg3));
    }

    return true;
}

static bool File_Open__String__FileMode__FileAccess(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 3) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.IO.FileMode arg1 = (System.IO.FileMode)JSApi.getEnum((int)JSApi.GetType.Arg);
        System.IO.FileAccess arg2 = (System.IO.FileAccess)JSApi.getEnum((int)JSApi.GetType.Arg);
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, System.IO.File.Open(arg0, arg1, arg2));
    }

    return true;
}

static bool File_Open__String__FileMode(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.IO.FileMode arg1 = (System.IO.FileMode)JSApi.getEnum((int)JSApi.GetType.Arg);
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, System.IO.File.Open(arg0, arg1));
    }

    return true;
}

static bool File_OpenRead__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, System.IO.File.OpenRead(arg0));
    }

    return true;
}

static bool File_OpenText__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, System.IO.File.OpenText(arg0));
    }

    return true;
}

static bool File_OpenWrite__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
                JSMgr.datax.setObject((int)JSApi.SetType.Rval, System.IO.File.OpenWrite(arg0));
    }

    return true;
}

static bool File_ReadAllBytes__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
                var arrRet = System.IO.File.ReadAllBytes(arg0);
        for (int i = 0; arrRet != null && i < arrRet.Length; i++)
        {
            JSApi.setByte((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
            JSApi.moveSaveID2Arr(i);
        }
        JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
    }

    return true;
}

static bool File_ReadAllLines__String__Encoding(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.Text.Encoding arg1 = (System.Text.Encoding)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
                var arrRet = System.IO.File.ReadAllLines(arg0, arg1);
        for (int i = 0; arrRet != null && i < arrRet.Length; i++)
        {
            JSApi.setStringS((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
            JSApi.moveSaveID2Arr(i);
        }
        JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
    }

    return true;
}

static bool File_ReadAllLines__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
                var arrRet = System.IO.File.ReadAllLines(arg0);
        for (int i = 0; arrRet != null && i < arrRet.Length; i++)
        {
            JSApi.setStringS((int)JSApi.SetType.SaveAndTempTrace, arrRet[i]);
            JSApi.moveSaveID2Arr(i);
        }
        JSApi.setArrayS((int)JSApi.SetType.Rval, (arrRet != null ? arrRet.Length : 0), true);
    }

    return true;
}

static bool File_ReadAllText__String__Encoding(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.Text.Encoding arg1 = (System.Text.Encoding)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
                JSApi.setStringS((int)JSApi.SetType.Rval, System.IO.File.ReadAllText(arg0, arg1));
    }

    return true;
}

static bool File_ReadAllText__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 1) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
                JSApi.setStringS((int)JSApi.SetType.Rval, System.IO.File.ReadAllText(arg0));
    }

    return true;
}

static bool File_Replace__String__String__String__Boolean(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 4) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.String arg1 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.String arg2 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.Boolean arg3 = (System.Boolean)JSApi.getBooleanS((int)JSApi.GetType.Arg);
        System.IO.File.Replace(arg0, arg1, arg2, arg3);
    }

    return true;
}

static bool File_Replace__String__String__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 3) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.String arg1 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.String arg2 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.IO.File.Replace(arg0, arg1, arg2);
    }

    return true;
}

static bool File_SetAccessControl__String__FileSecurity(JSVCall vc, int argc)
{
    UnityEngine.Debug.LogError("This method is not supported by .Net 2.0 subset.");
    return true;
}

static bool File_SetAttributes__String__FileAttributes(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.IO.FileAttributes arg1 = (System.IO.FileAttributes)JSApi.getEnum((int)JSApi.GetType.Arg);
        System.IO.File.SetAttributes(arg0, arg1);
    }

    return true;
}

static bool File_SetCreationTime__String__DateTime(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.DateTime arg1 = (System.DateTime)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        System.IO.File.SetCreationTime(arg0, arg1);
    }

    return true;
}

static bool File_SetCreationTimeUtc__String__DateTime(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.DateTime arg1 = (System.DateTime)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        System.IO.File.SetCreationTimeUtc(arg0, arg1);
    }

    return true;
}

static bool File_SetLastAccessTime__String__DateTime(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.DateTime arg1 = (System.DateTime)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        System.IO.File.SetLastAccessTime(arg0, arg1);
    }

    return true;
}

static bool File_SetLastAccessTimeUtc__String__DateTime(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.DateTime arg1 = (System.DateTime)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        System.IO.File.SetLastAccessTimeUtc(arg0, arg1);
    }

    return true;
}

static bool File_SetLastWriteTime__String__DateTime(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.DateTime arg1 = (System.DateTime)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        System.IO.File.SetLastWriteTime(arg0, arg1);
    }

    return true;
}

static bool File_SetLastWriteTimeUtc__String__DateTime(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.DateTime arg1 = (System.DateTime)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        System.IO.File.SetLastWriteTimeUtc(arg0, arg1);
    }

    return true;
}

static bool File_WriteAllBytes__String__Byte_Array(JSVCall vc, int argc)
{
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
        System.IO.File.WriteAllBytes(arg0, arg1);
    }

    return true;
}

static bool File_WriteAllLines__String__String_Array__Encoding(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 3) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.String[] arg1 = JSDataExchangeMgr.GetJSArg<System.String[]>(() =>
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
        System.Text.Encoding arg2 = (System.Text.Encoding)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        System.IO.File.WriteAllLines(arg0, arg1, arg2);
    }

    return true;
}

static bool File_WriteAllLines__String__String_Array(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.String[] arg1 = JSDataExchangeMgr.GetJSArg<System.String[]>(() =>
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
        System.IO.File.WriteAllLines(arg0, arg1);
    }

    return true;
}

static bool File_WriteAllText__String__String__Encoding(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 3) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.String arg1 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.Text.Encoding arg2 = (System.Text.Encoding)JSMgr.datax.getObject((int)JSApi.GetType.Arg);
        System.IO.File.WriteAllText(arg0, arg1, arg2);
    }

    return true;
}

static bool File_WriteAllText__String__String(JSVCall vc, int argc)
{
    int len = argc;
    if (len == 2) 
    {
        System.String arg0 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.String arg1 = (System.String)JSApi.getStringS((int)JSApi.GetType.Arg);
        System.IO.File.WriteAllText(arg0, arg1);
    }

    return true;
}


//register

public static void __Register()
{
    JSMgr.CallbackInfo ci = new JSMgr.CallbackInfo();
    ci.type = typeof(System.IO.File);
    ci.fields = new JSMgr.CSCallbackField[]
    {

    };
    ci.properties = new JSMgr.CSCallbackProperty[]
    {

    };
    ci.constructors = new JSMgr.MethodCallBackInfo[]
    {

    };
    ci.methods = new JSMgr.MethodCallBackInfo[]
    {
        new JSMgr.MethodCallBackInfo(File_AppendAllText__String__String__Encoding, "AppendAllText"),
        new JSMgr.MethodCallBackInfo(File_AppendAllText__String__String, "AppendAllText"),
        new JSMgr.MethodCallBackInfo(File_AppendText__String, "AppendText"),
        new JSMgr.MethodCallBackInfo(File_Copy__String__String__Boolean, "Copy"),
        new JSMgr.MethodCallBackInfo(File_Copy__String__String, "Copy"),
        new JSMgr.MethodCallBackInfo(File_Create__String__Int32__FileOptions__FileSecurity, "Create"),
        new JSMgr.MethodCallBackInfo(File_Create__String__Int32__FileOptions, "Create"),
        new JSMgr.MethodCallBackInfo(File_Create__String__Int32, "Create"),
        new JSMgr.MethodCallBackInfo(File_Create__String, "Create"),
        new JSMgr.MethodCallBackInfo(File_CreateText__String, "CreateText"),
        new JSMgr.MethodCallBackInfo(File_Decrypt__String, "Decrypt"),
        new JSMgr.MethodCallBackInfo(File_Delete__String, "Delete"),
        new JSMgr.MethodCallBackInfo(File_Encrypt__String, "Encrypt"),
        new JSMgr.MethodCallBackInfo(File_Exists__String, "Exists"),
        new JSMgr.MethodCallBackInfo(File_GetAccessControl__String__AccessControlSections, "GetAccessControl"),
        new JSMgr.MethodCallBackInfo(File_GetAccessControl__String, "GetAccessControl"),
        new JSMgr.MethodCallBackInfo(File_GetAttributes__String, "GetAttributes"),
        new JSMgr.MethodCallBackInfo(File_GetCreationTime__String, "GetCreationTime"),
        new JSMgr.MethodCallBackInfo(File_GetCreationTimeUtc__String, "GetCreationTimeUtc"),
        new JSMgr.MethodCallBackInfo(File_GetLastAccessTime__String, "GetLastAccessTime"),
        new JSMgr.MethodCallBackInfo(File_GetLastAccessTimeUtc__String, "GetLastAccessTimeUtc"),
        new JSMgr.MethodCallBackInfo(File_GetLastWriteTime__String, "GetLastWriteTime"),
        new JSMgr.MethodCallBackInfo(File_GetLastWriteTimeUtc__String, "GetLastWriteTimeUtc"),
        new JSMgr.MethodCallBackInfo(File_Move__String__String, "Move"),
        new JSMgr.MethodCallBackInfo(File_Open__String__FileMode__FileAccess__FileShare, "Open"),
        new JSMgr.MethodCallBackInfo(File_Open__String__FileMode__FileAccess, "Open"),
        new JSMgr.MethodCallBackInfo(File_Open__String__FileMode, "Open"),
        new JSMgr.MethodCallBackInfo(File_OpenRead__String, "OpenRead"),
        new JSMgr.MethodCallBackInfo(File_OpenText__String, "OpenText"),
        new JSMgr.MethodCallBackInfo(File_OpenWrite__String, "OpenWrite"),
        new JSMgr.MethodCallBackInfo(File_ReadAllBytes__String, "ReadAllBytes"),
        new JSMgr.MethodCallBackInfo(File_ReadAllLines__String__Encoding, "ReadAllLines"),
        new JSMgr.MethodCallBackInfo(File_ReadAllLines__String, "ReadAllLines"),
        new JSMgr.MethodCallBackInfo(File_ReadAllText__String__Encoding, "ReadAllText"),
        new JSMgr.MethodCallBackInfo(File_ReadAllText__String, "ReadAllText"),
        new JSMgr.MethodCallBackInfo(File_Replace__String__String__String__Boolean, "Replace"),
        new JSMgr.MethodCallBackInfo(File_Replace__String__String__String, "Replace"),
        new JSMgr.MethodCallBackInfo(File_SetAccessControl__String__FileSecurity, "SetAccessControl"),
        new JSMgr.MethodCallBackInfo(File_SetAttributes__String__FileAttributes, "SetAttributes"),
        new JSMgr.MethodCallBackInfo(File_SetCreationTime__String__DateTime, "SetCreationTime"),
        new JSMgr.MethodCallBackInfo(File_SetCreationTimeUtc__String__DateTime, "SetCreationTimeUtc"),
        new JSMgr.MethodCallBackInfo(File_SetLastAccessTime__String__DateTime, "SetLastAccessTime"),
        new JSMgr.MethodCallBackInfo(File_SetLastAccessTimeUtc__String__DateTime, "SetLastAccessTimeUtc"),
        new JSMgr.MethodCallBackInfo(File_SetLastWriteTime__String__DateTime, "SetLastWriteTime"),
        new JSMgr.MethodCallBackInfo(File_SetLastWriteTimeUtc__String__DateTime, "SetLastWriteTimeUtc"),
        new JSMgr.MethodCallBackInfo(File_WriteAllBytes__String__Byte_Array, "WriteAllBytes"),
        new JSMgr.MethodCallBackInfo(File_WriteAllLines__String__String_Array__Encoding, "WriteAllLines"),
        new JSMgr.MethodCallBackInfo(File_WriteAllLines__String__String_Array, "WriteAllLines"),
        new JSMgr.MethodCallBackInfo(File_WriteAllText__String__String__Encoding, "WriteAllText"),
        new JSMgr.MethodCallBackInfo(File_WriteAllText__String__String, "WriteAllText"),

    };
    JSMgr.allCallbackInfo.Add(ci);
}


}

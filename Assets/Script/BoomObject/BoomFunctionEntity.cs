using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class BoomFunctionEntity : BoomEntity  
{
    public static new BoomClassUID RTTI = new BoomClassUID("BoomFunctionEntity", new BoomFunctionEntity());

    public override BoomClassUID GetRTTI()
    {
        return BoomFunctionEntity.RTTI;
    }

    public BoomFunctionEntity()
    {

    }

    public override BoomObject CreateInstance()
    {
        return new BoomFunctionEntity();
    }

    protected Dictionary<BoomClassUID,BoomFunction> m_FunctionList = new Dictionary<BoomClassUID, BoomFunction>();


    public BoomFunction AddFunction(BoomClassUID type)
    {
        if (!m_FunctionList.ContainsKey(type))
        {
          
            m_FunctionList.Add(type, type.CreateInstance() as BoomFunction);
            m_FunctionList[type].Init(this);
        }
        m_FunctionList[type].AddRef();
        return m_FunctionList[type];

    }

    public BoomFunction GetFunction(BoomClassUID type)
    {
        if (!m_FunctionList.ContainsKey(type))
        {
            return null;
        }
        return m_FunctionList[type];
    }

    public void ReleaseFunction(BoomClassUID type)
    {
        if (!m_FunctionList.ContainsKey(type))
        {
            return;
        }
        m_FunctionList[type].Release();
        if (m_FunctionList[type].RefCount == 0)
        {
            m_FunctionList.Remove(type);
        }
    }
}

using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class BoomFunctionEntity : BoomEntity  
{
    protected Dictionary<Type,BoomFunction> m_FunctionList;


    public void AddFunction(BoomFunction function)
    {
        m_FunctionList.Add(function.GetType(), function);
        function.Init();
    }

    public void RemoveFunction(BoomFunction function)
    {
        m_FunctionList.Remove(function.GetType());
        function.Discard();
    }
}

using UnityEngine;
using System.Collections;

public class BoomMove : BoomFunction
{
    public override void Init()
    {
       
        if (Owner.HaveData(System.Type.GetType(BoomTransFormData)))
        {

        }
    }


    public override void  ExecuteFunction()
    {
       // Owner.
    }

    public override void Discard()
    {
        
    }

}

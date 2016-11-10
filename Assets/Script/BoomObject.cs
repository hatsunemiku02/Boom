using UnityEngine;
using System.Collections;

public class BoomObject
{
    public static BoomClassUID RTTI = new BoomClassUID("BoomObject");
   
    public virtual BoomClassUID GetRTTI()
    {
        return BoomObject.RTTI;
    }
}

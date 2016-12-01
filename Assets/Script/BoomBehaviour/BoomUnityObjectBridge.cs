using UnityEngine;
using System.Collections;

public class BoomUnityObjectBridge : BoomBehaviour {

    public BoomEntity EntityForBoom
    {
        set;
        get;
    }

    public GameObject ObjectForUnity
    {
        get
        {
            return gameObject;
        }
    }
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

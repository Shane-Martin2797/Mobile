using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.Events;

[System.Serializable]
public class IAPProduct {

	public string productStringID;
	public ProductType productType;
	public UnityEvent FuctionToCallOnPurchaseComplete;
}

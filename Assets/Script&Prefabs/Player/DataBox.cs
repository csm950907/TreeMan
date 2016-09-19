using UnityEngine;
using System.Collections;

public class DataBox : MonoBehaviour{
	private static DataBox instance = null;
	private Hashtable table;
	public DataBox()
	{
		table = new Hashtable ();
		ItemData data = new ItemData (
			"Image/Apple.perfab", "Real/Apple.perfab", "Virtual/Apple.perfab");
		table ["apple"] = data;
	}
	public static DataBox GetInstance()
	{
		if (instance == null)
			instance = new DataBox ();
		return instance;
	}
	public static ItemData GetItemData(string name)
	{
		return (ItemData) GetInstance ().table [name];
	}
}

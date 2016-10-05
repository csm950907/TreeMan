using UnityEngine;
using System.Collections;

public class DataBox {
	private static DataBox instance = null;
	private Hashtable table;
	public DataBox()
	{
		table = new Hashtable ();
		ItemData temp = new ItemData (
			"Image/Apple", "Real/Apple", "Virtual/Apple");
        table ["Apple"] = temp;
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

using UnityEngine;
using System.Collections;

public class ItemData : MonoBehaviour{
	private GameObject image;
	private GameObject real;
	private GameObject virutal;
	private string sImage, sReal, sVirtual;
	public ItemData(string sImage, string sReal, string sVirtual)
	{
		Load (sImage, sReal, sVirtual);
	}

	GameObject GetImage() {
		return image;
	}

	GameObject GetReal() {
		return real;
	}

	GameObject GetVirtual() {
		return real;
	}

	void Load(string sImage, string sReal, string sVirtual)
	{
		this.sImage = sImage;
		this.sReal = sReal;
		this.sVirtual = sVirtual;

		if (sImage != null) {
			image = Resources.Load (sImage) as GameObject;
		}
		if (sReal != null) {
			real = Resources.Load (sReal) as GameObject;
		}
		if (sVirtual != null) {
			virutal = Resources.Load (sVirtual) as GameObject;
		}
	}
}

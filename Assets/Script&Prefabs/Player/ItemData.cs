using UnityEngine;
using System.Collections;

public class ItemData {
	private GameObject image;
	private GameObject real;
	private GameObject vtual;
	private string sImage, sReal, sVirtual;
	public ItemData(string sImage, string sReal, string sVirtual)
	{
		Load (sImage, sReal, sVirtual);
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
            vtual = Resources.Load (sVirtual) as GameObject;
        }
    }

    public GameObject GetImage()
    {
        return image;
    }

    public GameObject GetReal()
    {
        return real;
    }

    public GameObject GetVirtual()
    {
        return vtual;
    }
}

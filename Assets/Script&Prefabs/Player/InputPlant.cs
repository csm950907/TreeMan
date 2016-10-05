using UnityEngine;
using System.Collections;

public class InputPlant : MonoBehaviour {
	RaycastHit hit;
	public Camera camera;
	public GameObject handInventory;
    public ItemData data = null;
    int prevKey = -1;
    bool FixMouseKey = false;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update ()
    {
        InputKey();
        InputMouse();
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 3))
        {
            if(data != null)
            {
                GameObject obj = GameObject.FindGameObjectWithTag("CurrentVirtual");
                if(obj != null)
                {
                    obj.transform.position = hit.point;
                }
            }
        }
    }

    void InputMouse()
    {
        if(Input.GetMouseButtonDown(0) && !FixMouseKey && data != null)
        {
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 3))
            {
                GameObject obj = data.GetReal();
                obj.tag = "Tree";
                Instantiate(obj, hit.point, Quaternion.identity);
                FixMouseKey = true;
            }
        }
        if(Input.GetMouseButtonUp(0))
        {
            FixMouseKey = false;
        }
        if(Input.GetMouseButtonDown(1))
        {
            GameObject d = GameObject.FindGameObjectWithTag("CurrentVirtual");
            if (d != null)
            {
                Destroy(d);
            }
            prevKey = -1;
            data = null;
        }
    }

    void InputKey()
    {
        int key = CheckKey();
        if (key >= 0 && prevKey != key)
        {
            GameObject d = GameObject.FindGameObjectWithTag("CurrentVirtual");
            if (d != null)
            {
                Destroy(d);
            }
            if (handInventory)
            {
                GameObject slot = handInventory.transform.Find("Slot (" + key + ")").gameObject;
                if (slot)
                {
                    GameObject item = slot.GetComponent<Slot>().item;
                    if (item != null)
                    {
                        prevKey = key;
                        data = DataBox.GetItemData(item.name);
                        GameObject obj = data.GetVirtual();
                        obj.tag = "CurrentVirtual";
                        Instantiate(obj, new Vector3(1, 0, 1), Quaternion.identity);
                    }
                }
            }
        }
    }

	int CheckKey()
	{
		if (Input.GetKey (KeyCode.Alpha1))
			return 1;
		if (Input.GetKey (KeyCode.Alpha2))
			return 2;
		if (Input.GetKey (KeyCode.Alpha3))
			return 3;
		if (Input.GetKey (KeyCode.Alpha4))
			return 4;
		if (Input.GetKey (KeyCode.Alpha5))
			return 5;
		if (Input.GetKey (KeyCode.Alpha6))
			return 6;
		if (Input.GetKey (KeyCode.Alpha7))
			return 7;
		if (Input.GetKey (KeyCode.Alpha8))
			return 8;
		if (Input.GetKey (KeyCode.Alpha9))
			return 9;
		if (Input.GetKey (KeyCode.Alpha0))
			return 0;
		return -1;
	}
}

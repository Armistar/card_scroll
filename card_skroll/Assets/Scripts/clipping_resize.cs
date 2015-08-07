using UnityEngine;
using System.Collections;

public class clipping_resize : MonoBehaviour {

	public Transform backsize;
	private Vector3 previous_size;
	private UIPanel clipping_panel;

	void Start() {
		clipping_panel = gameObject.GetComponent<UIPanel>();
	}

	void Update () {
		if(previous_size.x != backsize.transform.localScale.x || previous_size.y != backsize.transform.localScale.y)
			clipping_panel.clipRange = new Vector4 (clipping_panel.clipRange.x,
			                                        clipping_panel.clipRange.y,
			                                        backsize.transform.localScale.x,
			                                        backsize.transform.localScale.y);
	}
}

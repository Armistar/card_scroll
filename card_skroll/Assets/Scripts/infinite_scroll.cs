using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class infinite_scroll : MonoBehaviour {

	public UIPanel clipping_panel;

	private List<Transform> cards;
	
	void Start () {
		cards = new List<Transform>();

		for (int i = 0; i < transform.childCount; i++)
		{
			Transform child = transform.GetChild(i);

			if (child.GetComponent<UISprite>() != null){
				cards.Add(child);
			}
		}

		cards = cards.OrderBy(
			t => t.position.x
			).ToList();
	}

	/*Not best realisation of infinite scroll from point of resource using, but very simple in code*/
	void FixedUpdate () {
		if(clipping_panel.IsVisible(cards.First().position)) {
			cards.Last().localPosition = new Vector3 (cards.First().localPosition.x-50,0,0);


			cards = cards.OrderBy(
				t => t.position.x
				).ToList();
		}
		if(clipping_panel.IsVisible(cards.Last().position)) {
			cards.First().localPosition = new Vector3 (cards.Last().localPosition.x+50,0,0);
			
			
			cards = cards.OrderBy(
				t => t.position.x
				).ToList();
		}
	}
}

using UnityEngine;
using System.Collections;

public class deck_generator : MonoBehaviour {

	public GameObject[] cards;
	public Transform parent_object;


	void Awake () {
		int j = 0;

		for(int i=0; i<54; i++){
			GameObject card = Instantiate(cards[j]);
			card.transform.parent = parent_object;
			card.transform.localPosition = new Vector3(i*50, 0, 0);
			card.transform.localScale = new Vector3(120, 150, 1);

			//Because there only prototype, used only 3 sample "cards", first used as marker
			if(j==0) j++;
			else if (j==1) j++;
			else j--;
		}
	}

	void Update () {
	
	}
}

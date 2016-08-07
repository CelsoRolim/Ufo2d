using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static GameManager instance = null;
	public GameObject winText;
	private int numberOfCollectables = 6;
	private int collectablesHit;

	void Awake()
	{
		if (instance == null) 
		{
			instance = this;
		} else 
		{
			Destroy (gameObject);
		}
	}

	void Start()
	{
		collectablesHit = 0;
	}

	public void HitCollectables()
	{
		collectablesHit++;

		if(collectablesHit >= numberOfCollectables)
		{
			winText.SetActive (true);
		}
	}
}

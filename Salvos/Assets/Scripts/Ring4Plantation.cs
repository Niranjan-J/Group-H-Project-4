﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ring4Plantation : MonoBehaviour {
	public GameObject m,dr,re1,re2;
	
	private void OnTriggerEnter(Collider other) {
		Destroy(gameObject);
		ScoreController.i++;
		m.SetActive(true);
		Destroy(dr);
		re1.SetActive(true);
		re2.SetActive(true);
	}
}
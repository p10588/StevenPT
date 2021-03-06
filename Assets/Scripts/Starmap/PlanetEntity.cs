﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetEntity : SpaceEntity {
	public GameObject halo;
	public Collider2D colli;
	public bool exploded = false;

	// Start is called before the first frame update
	void Awake() {
		GetComponent<Collider2D>();
	}

	// Update is called once per frame
	void Update()
    {
        
    }

	public void Regist(StarInfo info, Material mat, float size, bool haveHalo) {
		Regist(info, mat, size);
		halo.SetActive(haveHalo);
	}

	void OnTriggerEnter2D(Collider2D colli) {
		SYS_ResourseManager.Direct.ModifyFuel(40);
		exploded = true;
	}

	void OnTriggerExit2D(Collider2D colli) {

	}
}

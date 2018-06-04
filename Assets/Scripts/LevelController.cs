﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour {

	public static LevelController Current;
	void Awake() {
		Current = this;
	}

	public void OnRabitDeath(HeroRabbit heroRabbit)
	{
		heroRabbit.OnRabitDeath();
	}
	
}
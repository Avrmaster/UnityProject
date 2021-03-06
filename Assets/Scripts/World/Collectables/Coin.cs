﻿using Herorabbit;

namespace World.Collectables
{
    public class Coin : Collectable
    {
        protected override void OnRabitHit(HeroRabbit rabbit)
        {
            base.OnRabitHit(rabbit);
            LevelController.Current.OnCollectCoin();
        }
    }
}
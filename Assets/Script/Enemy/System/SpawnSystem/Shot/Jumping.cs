﻿public class Jumping : IEnemyGeneration
{
    public void Movement(EnemyController enemy)
    {
        if (enemy.EnemySystem is not Shot) { return; }

        var shot = (Shot)enemy.EnemySystem;
    }
}

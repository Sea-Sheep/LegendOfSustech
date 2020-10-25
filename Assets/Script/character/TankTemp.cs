﻿//一次答辩用，坦克
public class TankTemp : Character
{
    public TankTemp() : base(3600, 1000, 40)
    {
    }

    protected override int Skill()
    {
        double atk = base.Count_atk();
        double damage = base.Count_damage(2 * atk);
        Get_target()[0].Defense(damage);
        return 1;
    }

    protected override void Die()
    {
    }
}
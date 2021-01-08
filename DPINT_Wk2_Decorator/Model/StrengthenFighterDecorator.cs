using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPINT_Wk2_Decorator.Model
{
    public class StrengthenFighterDecorator : BaseFighterDecorator
    {
        public StrengthenFighterDecorator(IFighter fighter) : base(fighter)
        {
            fighter.AttackValue = Convert.ToInt32(fighter.AttackValue * 1.1);
            fighter.DefenseValue = Convert.ToInt32(fighter.DefenseValue* 1.1);

        }

        //public override Attack Attack()
        //{
        //    var attack = base.Attack();
        //    attack.Value = Convert.ToInt32(attack.Value * 1.1);
        //    return attack;

        //}

        //public override void Defend(Attack attack)
        //{
        //    attack.Value = Convert.ToInt32(attack.Value * 0.9);
        //    base.Defend(attack);
        //}

    }
}

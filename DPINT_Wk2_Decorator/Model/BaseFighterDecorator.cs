using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPINT_Wk2_Decorator.Model
{
    public abstract class BaseFighterDecorator : IFighter
    {
        private IFighter _fighter;

        public virtual int Lives { get => _fighter.Lives; set => _fighter.Lives = value; }
        public virtual int AttackValue { get => _fighter.AttackValue; set => _fighter.AttackValue = value; }
        public virtual int DefenseValue { get => _fighter.DefenseValue; set => _fighter.DefenseValue = value; }

        public BaseFighterDecorator(IFighter fighter)
        {
            _fighter = fighter;
        }

        public virtual Attack Attack()
        {
            return _fighter.Attack();
        }

        public virtual void Defend(Attack attack)
        {
            _fighter.Defend(attack);
        }
    }
}

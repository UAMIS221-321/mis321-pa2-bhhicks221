using System;

namespace mis321_pa2_bhhicks221
{
    public class WillTurner : Character
    {
        public string Title {get; set;}
        public IAttack attackBehavior {get; set;}
        public WillTurner()
        {
            Title = "Will Turner";
            attackBehavior = new Sword();
        }
    }
}
using System;

namespace mis321_pa2_bhhicks221
{
    public class DavyJones : Character
    {
        public string Title {get; set;}
        public DavyJones()
        {
            Title = "Davy Jones";
            attackBehavior = new CannonFire();
            defendBehavior = new CannonFireDefend();
        }
    }
}
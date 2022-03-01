using System;
namespace mis321_pa2_bhhicks221
{
    public class JackSparrow : Character
    {
        public string Title{get; set;}
        public JackSparrow()
        {
            Title = "Jack Sparrow";
            attackBehavior = new Distract();
            defendBehavior = new DistractDefend();
        }
    }
}
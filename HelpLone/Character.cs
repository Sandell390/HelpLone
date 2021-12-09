using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpLone
{
    public abstract class Character
    {
        public void Heal()
        {
            Console.WriteLine("I'm healing");
        }

        public void Die()
        {
            Console.WriteLine("I'm dying");
        }

        public void Fight()
        {
            Console.WriteLine("I'm fighting");
        }
    }

    // --Character--
    //Heal: All
    //Die: All
    //Fight: All

    // --ThrowingSpells
    //ThrowMagicMisile: Wizard
    //ThrowFrostNova: Wizard

    // --CommonMagic--
    //Teleport: Wizard, Witch

    // --IShield--
    //RaiseShield: Knight, Witch
    //ShieldGlare: Knight, Witch


    // --IHeavyAttack--
    //Bash: Babarian, Knight
    //Cleave: Babarian, Knight


    // --ILightAttack--
    //Slash: Babarian, Knight

}

using DesignPatternSimulator.designpattern.strategie.comportement.guerre.combat.parent;

namespace DesignPatternSimulator.designpattern.strategie.comportement.guerre.combat
{
    public class ComportementDeArcher : ComportementDeCombat
    {

        public override string Combattre()
        {
            return "je me bats avec un arc";
        }

    }
}
using DesignPatternSimulator.designpattern.fabrique.personnage.football;
using DesignPatternSimulator.designpattern.fabrique.personnage.guerre;
using DesignPatternSimulator.designpattern.observateur;
using DesignPatternSimulator.designpattern.strategie.personnage;

namespace DesignPatternSimulator.designpattern.fabrique.personnage
{
	public abstract class FactoryPersonnage {
	

        //public abstract Personnage CreatePersonnage(eTypePersonnage type, Organisation org, string nom);
        public abstract Personnage CreatePersonnage(eTypePersonnage type, Organisation org, string nom);

    }
}
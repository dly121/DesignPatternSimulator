using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DesignPatternSimulator.designpattern.environnement.parent;
using DesignPatternSimulator.designpattern.environnement.style;
using DesignPatternSimulator.designpattern.fabrique.plateaudejeu;
using DesignPatternSimulator.designpattern.fabrique.plateaudejeu.guerre;
using DesignPatternSimulator.designpattern.strategie.personnage;
using DesignPatternSimulator.designpattern.environnement.style.parent;

namespace DesignPatternSimulator.designpattern.environnement
{
	public class EnvironnementDeJeuMoyenAge : EnvironnementDeJeu {

        public PlateauDeJeu plateau { get; set; }

		public override AbstractPlateauDeJeu CreerPlateauDeJeu(AbstractFabriqueDeJeu fabrique) {
			PlateauDeJeu winterfell = new PlateauDeJeu();
			FactoryDeJeuGuerre factory = new FactoryDeJeuGuerre();

            //List<Acces> casesWinterfell = new List<Acces>();
            List<AbstractZone> casesWinterfell = new List<AbstractZone>();
			casesWinterfell = factory.CreateCarre(10, 10);
		
			//int sizeCarre = Integer.valueOf(casesWinterfell.get(casesWinterfell.size()).secondZoneName().split(":")[1]);
		
			winterfell.setZonesAcces(casesWinterfell);

            plateau = winterfell;
			return plateau;
		}

        public override AbstractPlateauDeJeu GetPlateauDeJeu()
        {
            return plateau;
        }


        public void PlacerLesPions(List<Personnage> lesPerso)
        {
            List<AbstractZone> zones = plateau.getZonesAcces();

            int size = lesPerso.Count;
            int i = 0;
            AbstractZone zone;

            for (int j = 0; j < zones.Count && j < size; j++ )
            {
                zone = zones.ElementAt(j);
                lesPerso.ElementAt(i).Emplacement = zone;
                i++;
            }
        }

	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternSimulator.designpattern.environnement.style.parent;
using DesignPatternSimulator.designpattern.environnement.parent;
using DesignPatternSimulator.designpattern.environnement.style;


namespace DesignPatternSimulator.designpattern.environnement.parent
{
    public abstract class AbstractPlateauDeJeu
    {

        public abstract AbstractZone CreerZone();
        public abstract AbstractAcces CreerAcces();
        //public abstract void setZonesAcces(List<Acces> acces);
        public abstract void setZonesAcces(List<Zone> acces);
        //public abstract List<Acces> getZonesAcces();
        public abstract List<Zone> getZonesAcces();

    }
}
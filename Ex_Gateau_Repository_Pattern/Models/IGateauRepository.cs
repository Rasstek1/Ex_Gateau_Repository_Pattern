using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Collections.Generic;
using Ex_Gateau_Repository_Pattern.Models;

namespace Ex_Gateau_Repository_Pattern.Models
{
    public interface IGateauRepository
    {
        IEnumerable<Gateau> MesGateaux { get; }

        void AjouterGateau(Gateau gateau);

        void SupprimerGateau(int id);

        void ModifierGateau(Gateau gateau);

        Gateau GetGateau(int id);
       
    }

}

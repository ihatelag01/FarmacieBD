using LibrarieModele;
using System.Collections.Generic;

namespace NivelAccesDate
{
    public interface IStocareMedicamente : IStocareFactory
    {
        List<Medicament> GetMedicamente();
        bool AddMedicament(Medicament m);
        bool DeleteMedicament(int id);
        bool UpdateMedicamente(Medicament m);
    }
}

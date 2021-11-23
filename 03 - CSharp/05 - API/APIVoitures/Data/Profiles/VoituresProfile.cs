using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIVoitures.Data.Profiles
{
    public class VoituresProfile
    {
        CreateMap<Personne, PersonnesDTO>();
        CreateMap<PersonnesDTO, Personne>();
    }
}

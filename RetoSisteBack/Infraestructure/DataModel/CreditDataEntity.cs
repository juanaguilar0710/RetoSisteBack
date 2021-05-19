using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RetoSisteBack.Infraestructure.DataModel
{
    public class CreditDataEntity
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Celular { get; set; }
        public string Correo { get; set; }
        public string TipoID { get; set; }
        public string NumeroID{ get; set; }
        public string DireccionResidencia { get; set; }
        public string Ciudad { get; set; }
        public string Valor { get; set; }
        public string Cuotas { get; set; }
        public string Estado { get; set; }

    }

    public class CreditsPlatform : IRequest<List<CreditDataEntity>>
    {
        public string Platform { get; set; }
    }

    public class createCredit : IRequest<string>
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Celular { get; set; }
        public string Correo { get; set; }
        public string TipoID { get; set; }
        public string NumeroID { get; set; }
        public string DireccionResidencia { get; set; }
        public string Ciudad { get; set; }
        public string Valor { get; set; }
        public string Cuotas { get; set; }
        public string Estado { get; set; }
    }


    public class updateCredit : IRequest<string>
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Celular { get; set; }
        public string Correo { get; set; }
        public string TipoID { get; set; }
        public string NumeroID { get; set; }
        public string DireccionResidencia { get; set; }
        public string Ciudad { get; set; }
        public string Valor { get; set; }
        public string Cuotas { get; set; }
        public string Estado { get; set; }
    }

    public class deleteCredit : IRequest<string>
    {
        public string id { get; set; }
    }


}

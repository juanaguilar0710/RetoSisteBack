using Dapper;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using RetoSisteBack.Infraestructure.DataModel;
using RetoSisteBack.Settings;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace RetoSisteBack.Infraestructure.Repositories
{
    public class CreditsRepository : ICreditsRepository
    {
        private readonly string RetoSisteConnectionString;
        private readonly ILogger<CreditsRepository> logger;


        public CreditsRepository(IOptions<GlobalSettings> settings, ILogger<CreditsRepository> logger)
        {
            RetoSisteConnectionString = settings.Value.connectionStrings.BDRetoSiste;
            this.logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<string> createCredit(createCredit objCredit)
        {
            try
            {
                logger.LogInformation("Ejecución creación de credito");
                using (var connection = new SqlConnection(RetoSisteConnectionString))
                {
                    connection.Open();
                    var SQL = $@"INSERT INTO tblCredits (Nombres,Apellidos,Celular,Correo,TipoID,NumeroID,DireccionResidencia,Ciudad,Valor,Cuotas,Estado)
                                 VALUES ('{objCredit.Nombres}', '{objCredit.Apellidos}','{objCredit.Celular}', '{objCredit.Correo}','{objCredit.TipoID}','{objCredit.NumeroID}','{objCredit.DireccionResidencia}','{objCredit.Ciudad}','{objCredit.Valor}','{objCredit.Cuotas}','{objCredit.Estado}')";
                    var result = await connection.QueryAsync<dynamic>(SQL);

                    return "ok";
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<List<CreditDataEntity>> GetCredits(string platform)
        {
            List<CreditDataEntity> data = new List<CreditDataEntity>();

            try
            {
                logger.LogInformation("Ejecución consulta de creditos");
                using (var connection = new SqlConnection(RetoSisteConnectionString))
                {
                    connection.Open();
                    var result = await connection.QueryAsync<dynamic>(
                        $"select * from tblCredits"
                    );

                    if (result.AsList().Count > 0)
                    {
                        foreach (var credit in result)
                        {
                            data.Add(new CreditDataEntity()
                            {
                                Id = credit.id,
                                Nombres = credit.Nombres,
                                Apellidos = credit.Apellidos,
                                Celular = credit.Celular,
                                Correo = credit.Correo,
                                TipoID = credit.TipoID,
                                NumeroID = credit.NumeroID,
                                DireccionResidencia = credit.DireccionResidencia,
                                Ciudad = credit.Ciudad,
                                Valor = credit.Valor,
                                Cuotas = credit.Cuotas,
                                Estado = credit.Estado
                            });
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                logger.LogError(ex, $"Error en consulta información de las unidades.");
                throw ex;
            }

            return data;
        }

        public async Task<string> updateCredit(updateCredit objCredit)
        {        

            try
            {
                logger.LogInformation("Ejecución actualización de credito");
                using (var connection = new SqlConnection(RetoSisteConnectionString))
                {
                    var sql = $@"UPDATE tblCredits
                                SET Nombres = '{objCredit.Nombres}', Apellidos = '{objCredit.Apellidos}',  Celular = '{objCredit.Celular}', Correo = '{objCredit.Correo}', TipoID = '{objCredit.TipoID}', NumeroID = '{objCredit.NumeroID}', DireccionResidencia = '{objCredit.DireccionResidencia}', Ciudad = '{objCredit.Ciudad}', Valor = '{objCredit.Valor}', Cuotas = '{objCredit.Cuotas}', Estado = '{objCredit.Estado}'
                                WHERE id = {objCredit.Id};";

                    var result = await connection.QueryAsync<dynamic>(sql);

                    return "ok";
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public async Task<string> deleteCredit(deleteCredit id)
        {
            try
            {
                logger.LogInformation("Ejecución eliminacion de credito");
                using (var connection = new SqlConnection(RetoSisteConnectionString))
                {
                    var sql = $@"DELETE FROM tblCredits WHERE id = {id.id};";

                    var result = await connection.QueryAsync<dynamic>(sql);

                    return "ok";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
       }

       
    }
}

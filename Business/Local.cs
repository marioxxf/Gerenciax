using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Local
    {
        public int id { get; set; }
        public string nomeLocal { get; set; }
        public string logradouro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string longitude { get; set; }
        public string latitude { get; set; }

        public List<Local> ListarTodos()
        {
            var lista = new List<Local>();
            var itensDoBanco = new Database.Local();
            foreach (DataRow row in itensDoBanco.ListaServicos().Rows)
            {
                var local = new Local();
                local.id = Convert.ToInt32(row["id"]);
                local.nomeLocal = row["nomeLocal"].ToString();
                local.logradouro = row["logradouro"].ToString();
                local.cidade = row["cidade"].ToString();
                local.estado = row["estado"].ToString();
                local.longitude = row["longitude"].ToString();
                local.latitude = row["latitude"].ToString();
                lista.Add(local);
            }
            return lista;
        }

        public void Salvar()
        {
            new Database.Local().Salvar(this.nomeLocal, this.logradouro, this.cidade, this.estado, this.longitude, this.latitude);
        }
    }
}

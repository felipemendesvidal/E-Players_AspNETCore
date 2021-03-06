//prevenção de erros por bibliotecas
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using E_players_2.Models;
namespace E_players_2.Interfaces{
    public interface IEquipe{
        //metodos de crud: criar, ler, alterar e excluir
        void Create(Equipe e);

        List<Equipe> ReadAll();

        void Update(Equipe e);

        void Delete(int id);
         
    }//end interface iequipe
}//end namespace
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAlunos
{
    class Aluno
    {
        string matricula;

        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        DateTime dataNasc;

        public DateTime DataNasc
        {
            get { return dataNasc; }
            set { dataNasc = value; }
        }
        string endereco;

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        string cpf;

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        string genero;

        public string Genero
        {
            get { return genero; }
            set { genero = value; }
        }



    }
}

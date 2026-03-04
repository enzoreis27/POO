using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conceitos
{
    public class Cliente
    {
        private string _nome;

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (value.Length != 0)
                {
                    _nome = value;
                }
                else
                {
                    throw new Exception("O nome nao pode estar vazio");
                }

            }


        }

        private string _cpf;

        public string Cpf
        {
            get
            {
                return _cpf;
            }

            set
            {

                if (value.Length == 11)
                {

                    _cpf = value;

                }

                else
                {
                    throw new Exception("O cpf nao ter menos de 11 caracteres");

                }

            }
        }




    }
    public class Agencia
    {
        private string _numero;

        public string Numero
        {
            get
            {
                return _numero;
            }
            set
            {

                if (value.Length == 4)
                {

                    _numero = value;

                }

                else
                {
                    throw new Exception("O numero da agencia nao pode estar vazio");

                }
            }
        }

        private string _nome;

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {

                if (value.Length != 0)
                {
                    _nome = value;
                }
                else
                {
                    throw new Exception("O nome nao pode estar vazio");
                }
            }
        }

        private string _telefone;

        public string Telefone
        {
            get
            {
                return _telefone;
            }
            set
            {

                if (value.Length == 11)
                {
                    _telefone = value;
                }
                else
                {
                    throw new Exception("O numero de telefone tem que ter 10 digitos");
                }
            }
        }




    }
}

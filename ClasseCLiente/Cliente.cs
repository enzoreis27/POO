using System;
using System.Collections.Generic;
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
                if (value.Length == 0)
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

            set {

                if (value.Length == 0)
                {

                    _cpf = value;

                }

                else
                {
                    throw new Exception("O cpf nao pode estar vazio");

                }

            }
        }
    } }


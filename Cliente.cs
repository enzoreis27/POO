using System text;

namespace Conceitos

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
            if (_nome.length == 0)
            {
                _nome = value;
            }
            else {
                throw new Exception("O nome nao pode estar vazio")
                 }

        } 
        

    }
}

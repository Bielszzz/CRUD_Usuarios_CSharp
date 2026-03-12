using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Crud_Usuarios_CSharp.Services;

namespace Crud_Usuarios_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UsuarioService service = new UsuarioService();

            while (true)
            {
                Console.WriteLine("\n1 - Criar Usuário");
                Console.WriteLine("\n2 - Listar Usuário");
                Console.WriteLine("\n3 - Deletar Usuário");
                Console.WriteLine("\n4 - Buscar Usuário");
                Console.WriteLine("\n5 - Editar Usuário");
                Console.WriteLine("\n0 - Sair");

                Console.Write("\nEscolha: ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        service.CriarUsuario();
                        break;

                    case 2:
                        service.ListarUsuario();
                        break;

                    case 3:
                        service.DeletarUsuario();
                        break;

                    case 4:
                        service.BuscarUsuario(); 
                        break;

                    case 5:
                        service.EditarUsuario();
                        break;

                    case 0:
                        return;

                }
            }
        }
    }
}

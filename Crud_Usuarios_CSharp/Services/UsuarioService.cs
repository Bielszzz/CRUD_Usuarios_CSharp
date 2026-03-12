using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Crud_Usuarios_CSharp.Models;

namespace Crud_Usuarios_CSharp.Services
{
    public class UsuarioService
    {
        private List<Usuario> usuarios = new List<Usuario>();
        private int proximoId = 1;

        public void CriarUsuario()
        {
            Console.Write("\nNome: ");
            string nome = Console.ReadLine();

            Console.Write("\nEmail: ");
            string email = Console.ReadLine();

            Usuario usuario = new Usuario
            {
                Id = proximoId++,
                Nome = nome,
                Email = email

            };

            usuarios.Add(usuario);

            Console.WriteLine("\n================================");
            Console.WriteLine("Usuario cadastrado!");
            Console.WriteLine("================================");
        }

        public void ListarUsuario()
        {
            if (usuarios.Count > 0)
            {

                foreach (var u in usuarios)
                {
                    Console.WriteLine("\n=============================================================");
                    Console.WriteLine($"ID:{u.Id} - NOME:{u.Nome} - EMAIL:{u.Email}");
                    Console.WriteLine("=============================================================");
                }
            }

            else
            {
                Console.WriteLine("\n================================");
                Console.WriteLine("Nenhum usuário para listar");
                Console.WriteLine("================================");
            }
        }

        public void DeletarUsuario()
        {
            Console.Write("\nDigite o ID do usuario a ser removido: ");
            int id = int.Parse(Console.ReadLine());

            int removidos = usuarios.RemoveAll(u => u.Id == id);

            if (removidos > 0)
            {
                Console.WriteLine("\n================================");
                Console.WriteLine("Usuário removido!");
                Console.WriteLine("================================");
            }

            else
            {
                Console.WriteLine("\n================================");
                Console.WriteLine("Usuário não encontrado!");
                Console.WriteLine("================================");
            }
            
        }

        public void BuscarUsuario()
        {
            Console.Write("\nDigite o ID do usuário para a busca: ");
            int id = int.Parse(Console.ReadLine());

            var procurado = usuarios.FirstOrDefault(u => u.Id == id);

            if (procurado != null)
            {
                Console.WriteLine("\n================================");
                Console.WriteLine($"ID:{procurado.Id} \nNOME:{procurado.Nome} \nEMAIL:{procurado.Email}");
                Console.WriteLine("================================");
            }

            else
            {
                Console.WriteLine("\n================================");
                Console.WriteLine("Usuário não encontrado!");
                Console.WriteLine("================================");
            }
        }

        public void EditarUsuario()
        {
            Console.Write("\nDigite o ID do Usuário a ser editado: ");
            int id = int.Parse(Console.ReadLine());

            var editado = usuarios.FirstOrDefault(u => u.Id == id);


            if (editado != null)
            {
                Console.Write("\nDigite o novo nome do usuário: ");
                editado.Nome = Console.ReadLine();

                Console.Write("\nDigite o novo email do usuário: ");
                editado.Email = Console.ReadLine();
            }

            else
            {
                Console.WriteLine("\n================================");
                Console.WriteLine("Usuário não encontrado!");
                Console.WriteLine("================================");
            }

        }
    }
}

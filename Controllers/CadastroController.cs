using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoletopMvc.Models;
using RoletopMvc.Enums;
using RoletopMvc.Repositories;
using RoletopMvc.ViewModels;

namespace RoletopMvc.Controllers
{
    public class CadastroController : AbstractController
    {
        ClienteRepository clienterepository = new ClienteRepository();
        public IActionResult Index()
        {
            return View(new RespostaViewModel() { NomeView = "Cadastro", UsuarioEmail = ObterUsuarioSession(), UsuarioNome = ObterUsuarioNomeSession() });
        }
        public IActionResult CadastrarCliente(IFormCollection form)
        {
            ViewData["Action"] = "Cadastro";
            try
            {
                Cliente cliente = new Cliente(form["nome"], form["email"], form["telefone"], DateTime.Parse(form["data"]), form["cpf"], form["senha"], form["csenha"]);
                cliente.TipoUsuario = (uint)TipoUsuario.CLIENTE;
                
                var urlFoto = $"wwwroot\\{PATH_FOTOS}\\{cliente.Nome}\\perfil\\";

                GravarFoto(form.Files, urlFoto);

                 
                    cliente.URLFotoPerfil = urlFoto;
                

                clienterepository.Inserir(cliente);

                return View("Sucesso", new RespostaViewModel() { NomeView = "Cadastro", UsuarioEmail = ObterUsuarioSession(), UsuarioNome = ObterUsuarioNomeSession() });
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.StackTrace);
                return View("Erro", new RespostaViewModel() { NomeView = "Cadastro", UsuarioEmail = ObterUsuarioSession(), UsuarioNome = ObterUsuarioNomeSession() });
            }
        }
        public async void GravarFoto(IFormFileCollection arquivos, string urlFoto) { 
            foreach (var foto in arquivos)
            {   
                System.IO.Directory.CreateDirectory(urlFoto).Create();
                var file = System.IO.File.Create(urlFoto + foto.FileName);
                await foto.CopyToAsync(file);
                file.Close();
            }
        }
    }
}
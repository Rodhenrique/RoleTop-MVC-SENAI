using System;

namespace RoletopMvc.Models {
    public class Mensagem {
        public string MensagemDoCliente { get; set; }
        public string Email { get; set; }
        public DateTime Data { get; set; }
        public string Objetivo { get; set; }
        public Cliente cliente { get; set; }
        public uint Id{ get; set; }
        public Mensagem () {

        }
        public Mensagem (uint id,string email, string mensagens, DateTime date, string objetivo) {
            this.Email = email;
            this.MensagemDoCliente = mensagens;
            this.Data = date;
            this.Objetivo = objetivo;
            this.Id = id;
            this.cliente = new Cliente ();

        }
    }
}
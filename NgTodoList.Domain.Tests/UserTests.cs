using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace NgTodoList.Domain.Tests
{
    [TestClass]
    public class Dado_um_novo_usuario
    {
        [TestMethod]
        [TestCategory("User -  Novo Usuário")]
        [ExpectedException(typeof(Exception))]
        public void O_nome_deve_ser_valido()
        {
            var user = new User("", "eric_674@msn.com", "eric_674");
        }

        [TestMethod]
        [TestCategory("User -  Novo Usuário")]
        [ExpectedException(typeof(Exception))]
        public void O_Email_nao_deve_ser_vazio()
        {
            var user = new User("Eric da Silva Cardoso", "", "eric_674");
        }

        [TestMethod]
        [TestCategory("User -  Novo Usuário")]
        [ExpectedException(typeof(Exception))]
        public void O_Email_deve_ser_valido()
        {
            var user = new User("Eric da Silva Cardoso", "msn.com", "eric_674");
        }

        [TestMethod]
        [TestCategory("User -  Novo Usuário")]
        [ExpectedException(typeof(Exception))]
        public void A_Senha_deve_ser_valida()
        {
            var user = new User("Eric da Silva Cardoso", "eric_674@msn.com", "eric");
        }

        [TestMethod]
        [TestCategory("User -  Novo Usuário")]
        public void O_usuario_e_valido()
        {
            var user = new User("Eric da Silva Cardoso", "eric_674@msn.com", "eric_674");
            Assert.AreNotEqual(null, user);
        }
    } 

    [TestClass]
    public class Ao_alterar_senha
    {
        private User user = new User("Eric da Silva Cardoso", "eric_674@msn.com", "eric_674");

        [TestMethod]
        [TestCategory("User -  Alterar senha")]
        [ExpectedException(typeof(Exception))]
        public void O_email_deve_ser_valido() 
        {
            user.ChangePassword("", "eric_674", "eric_6742", "eric_6742");
        }

        [TestMethod]
        [TestCategory("User -  Alterar senha")]
        [ExpectedException(typeof(Exception))]
        public void O_nova_senha_deve_ser_valida() 
        {
            user.ChangePassword("eric_674@msn.com", "eric_674", "eric_674", "eric_6742");
        }

        [TestMethod]
        [TestCategory("User -  Alterar senha")]
        [ExpectedException(typeof(Exception))]
        public void Usuario_e_senha_deve_ser_validos() 
        {
            user.ChangePassword("eric_674", "eric", "eric_6742", "eric_6742");
        }

        [TestMethod]
        [TestCategory("User -  Alterar senha")]
        [ExpectedException(typeof(Exception))]
        public void A_confirmacao_de_senha_deve_ser_igual_a_nova_senha()
        {
             user.ChangePassword("eric_674@msn.com", "eric_674", "eric_674", "eric_6742");
        }
        

        [TestMethod]
        [TestCategory("User -  Alterar senha")]
        public void A_senha_deve_ser_encriptada() 
        {
            var password = "minhasenhasegura";
            user.ChangePassword("eric_674@msn.com", "eric_674", "eric_6742", "eric_6742");
            Assert.AreNotEqual(password, user.Password);
        }
    }
}

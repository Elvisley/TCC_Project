using ConsoleApplication8.Domain;
using ConsoleApplication8.infra_ado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication8.Application
{
    class RegisterServiceAdo
    {

        private RegisterRepositoryAdo _registerRepAdo;

        public RegisterServiceAdo()
        {
            
            _registerRepAdo = new RegisterRepositoryAdo();

        }
        

        public bool createRegisterAdo(Register reg)
        {
            try
            {
                _registerRepAdo.Add(reg);
                return true;
            }
            catch (Exception e)
            {
                throw new Exception("Erro ao salvar ADO : " + e.Message.ToString());
            }
        }
    }
}

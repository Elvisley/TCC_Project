using ConsoleApplication8.Domain;
using ConsoleApplication8.infra;
using System;

namespace ConsoleApplication8.Application
{
   public class RegisterService
    {

        private RegisterRepository _registerRep;

        public RegisterService()
        {
            _registerRep = new RegisterRepository();
        }

        public bool createRegister(Register reg)
        {
            try
            {
                _registerRep.Add(reg);
                return true;
            }
            catch(Exception e)
            {
                throw new Exception("Erro ao salvar: "+e.Message.ToString());
            }
        }


    }
}

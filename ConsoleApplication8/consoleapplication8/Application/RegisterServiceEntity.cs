using ConsoleApplication8.Domain;
using ConsoleApplication8.infra;
using ConsoleApplication8.infra_ado;
using System;
using System.Collections.Generic;

namespace ConsoleApplication8.Application
{
   public class RegisterServiceEntity
    {

        private RegisterRepository _registerRep;
        
        public RegisterServiceEntity()
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
                throw new Exception("Erro ao salvar Entity : "+e.Message.ToString());
            }
        }

        public IEnumerable<Register> list()
        {
            try
            {
                return _registerRep.Get();
            }
            catch(Exception e)
            {
                throw new Exception("Erro ao buscar Entity : " + e.Message.ToString());
            }

        }
        
        




    }
}

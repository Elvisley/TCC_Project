using ConsoleApplication8.Domain;
using ConsoleApplication8.infra.Repository;
using ConsoleApplication8.infra.Repository.Interfaces;

namespace ConsoleApplication8.infra
{
    class RegisterRepository : RepositoryBase<Register> , IRegisterRepository
    {

    }
}

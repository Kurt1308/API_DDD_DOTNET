using Domain.DTOs.User;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services.User
{
    public interface IUserService
    {
        //Task<UserEntity> Get ( Guid id );
        Task<UserDTO> Get ( Guid id );
        //Task<IEnumerable<UserEntity>> GetAll ( );
        Task<IEnumerable<UserDTO>> GetAll ( );
        //Task<UserEntity> Post ( UserEntity user );
        Task<UserDTOCreateResult> Post ( UserDTO user );
        //Task<UserEntity> Put ( UserEntity user );
        Task<UserDTOUpdateResult> Put ( UserDTO user );
        Task<bool> Delete(Guid id);
    }
}

using System;

namespace Homo.AuthApi
{
    public class EarlyAdopterDataservice
    {

        public static EarlyAdopter Create(DBContext dbContext, DTOs.EarlyAdopterForm dto)
        {
            EarlyAdopter newUser = new EarlyAdopter()
            {
                Email = dto.Email,
                Phone = dto.Phone,
                Fee = dto.Fee,
                CreatedAt = DateTime.Now,
                CreatedBy = 0,
                DeletedAt = null
            };
            try
            {
                dbContext.EarlyAdopter.Add(newUser);
                dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            return newUser;
        }

    }
}
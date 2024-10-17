using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class UserDTO
    {
        public BaseInfoDTO BaseInfo { get; set; } = new BaseInfoDTO();

        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Login { get; set; } = string.Empty;
        public string HashedPassword { get; set; } = string.Empty;
        public bool IsLogged { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string PictureFilePath { get; set; } = string.Empty; // chemin d'accès vers minio

        public int? LanguageId { get; set; }
        public LanguageDTO? Language { get; set; }
        public int? RoleId { get; set; }
        public RoleDTO? Role { get; set; }
        public ICollection<Article> Articles { get; set; } = new List<Article>();
    }
}

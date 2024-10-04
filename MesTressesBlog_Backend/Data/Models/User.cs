using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string HashedPassword { get; set; }
        public bool IsLogged { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string PictureFilePath { get; set; } // chemin d'accès vers minio

        public int? LanguageId { get; set; }
        public Language? Language { get; set; }
        public int? RoleId { get; set; }
        public Role? Role { get; set; }
        public ICollection<Article> Articles { get; set; } = new List<Article>();
    }
}

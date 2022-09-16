using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base_Linguagem.Reflection.Enumerator;

namespace Base_Linguagem.Reflection.DTOs
{
    public class TesteDTO
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Document { get; set; }
        public EDocumentType DocumentType { get; set; }
        public string Email { get; set; }
        public string CellPhone { get; set; }
        public EParticipantStatus Status { get; set; }
        public DateTime BirthDate { get; set; }
        public AddressDTO AddressDTO { get; set; }

    }
}

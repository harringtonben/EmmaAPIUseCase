using System.Collections.Generic;
using EmmaSharp;
using EmmaAPIUseCase.Models;
using EmmaSharp.Models;

namespace EmmaAPIUseCase.Services
{
    public class EmmaService
    {
        public List<Member> GetEmmaMembers()
        {
            var emmaSharp = new EmmaApi("infogoeshere", "andhere", "andhere");
            var myContacts = emmaSharp.ListMembers();
            
            var contactChange = new List<Member>();

            foreach (var contact in myContacts)
            {
                var transformMember = new Member
                {
                    email = contact.Email
                };
                
                contactChange.Add(transformMember);
            }

            return contactChange;
        }
    }
}
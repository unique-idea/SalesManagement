﻿using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IMemberRepository
    {
        IEnumerable<MemberObject> GetMembers();

        IEnumerable<string> GetMemberIDs();

        void InsertMember(MemberObject user);

        void UpdateMember(MemberObject user);

        void DeleteMember(int user);

        MemberObject Login(string email, string password);
    }
}
